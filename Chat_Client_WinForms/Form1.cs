using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chat_Client_WinForms
{
    public partial class Form1 : Form
    {
        private TcpClient client = null;
        private NetworkStream stream = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (UsernameInput.Text == "") // Reject blank usernames.
            {
                ChatText.AppendText("Username input is blank.\r\n");
                return;
            }
            try
            {
                IPAddress address = IPAddress.Parse(IPInput.Text);
                client = new TcpClient();
                await client.ConnectAsync(address, 42424); // Connect to server at specified address.
                stream = client.GetStream(); // Obtain network stream.
                await SendMessage(UsernameInput.Text, 1); // Send initial connection message.
            }
            catch (Exception ex)
            {
                ChatText.AppendText(ex.Message + "\r\n");
                return;
            }
            /* Change form controls after connection established. */
            IPInput.ReadOnly = true;
            IPInput.Cursor = Cursors.Default;
            UsernameInput.ReadOnly = true;
            UsernameInput.Cursor = Cursors.Default;
            ConnectButton.Enabled = false;
            SendButton.Enabled = true;
            while (true)
            {
                try {
                    await WaitForMessages(); // Loop to recieve messages from server.
                }
                catch (Exception ex)
                {
                    /* Revert form controls if connection to server is lost. */
                    ChatText.AppendText(ex.Message + "\r\n");
                    IPInput.ReadOnly = false;
                    IPInput.Cursor = Cursors.IBeam;
                    UsernameInput.ReadOnly = false;
                    UsernameInput.Cursor = Cursors.IBeam;
                    ConnectButton.Enabled = true;
                    SendButton.Enabled = false;
                    Users.Items.Clear();
                    break;
                }
            }
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (SendToAll.Checked)
                await SendMessage(InputText.Text, 2); // Send message to server.
            else if (SendToOne.Checked)
            {
                if (Users.Text == "")
                {
                    ChatText.AppendText("No currently selected user.");
                    return;
                }
                await SendMessage(InputText.Text, 3); // Send message to server.
                await SendMessage(Users.Text, 0); // Send recieving username to server.
            }
            InputText.Text = "";
        }

        private async Task SendMessage(string message, byte flag)
        {
            byte[] stringBytes = Encoding.ASCII.GetBytes(message);
            byte[] sendMessage;
            byte[] messageSize = BitConverter.GetBytes(stringBytes.Length);
            if (flag == 0)
            {
                /* If flag is 0, sendMessage indices 0-3 are reserved for size of string being sent. */
                sendMessage = new byte[stringBytes.Length + 4];
                messageSize.CopyTo(sendMessage, 0);
                stringBytes.CopyTo(sendMessage, 4);
            }
            else
            {
                /* If flag is not 0, sendMessage index 0 is reserved for message type flag, and indices
                   1-4 are reserved for the size of the string being sent. */
                sendMessage = new byte[stringBytes.Length + 5];
                sendMessage[0] = flag;
                messageSize.CopyTo(sendMessage, 1);
                stringBytes.CopyTo(sendMessage, 5);
            }
            await stream.WriteAsync(sendMessage, 0, sendMessage.Length);
        }

        private async Task WaitForMessages()
        {
            byte[] messageFlag = new byte[1];
            int x = await stream.ReadAsync(messageFlag, 0, messageFlag.Length);
            switch (messageFlag[0])
            {
                case 1: // Standard message for ChatText box.
                    await ProcessStandardMessage();
                    break;
                case 2: // Username message for Users list.
                    await ProcessUsernameMessage();
                    break;
                case 3: // Username disconnect message for Users list.
                    await ProcessUserDisconnectMessage();
                    break;
                default: // Invalid flag.
                    ChatText.AppendText("Invalid Message Flag\r\n");
                    break;
            }
        }

        private async Task ProcessStandardMessage()
        {
            string message = await ReadMessageBytes();
            message = message + "\r\n";
            ChatText.AppendText(message); // Append message to chat box.
        }

        private async Task ProcessUsernameMessage()
        {
            string message = await ReadMessageBytes();
            Users.Items.Add(message); // Add user to list of users.
        }

        private async Task ProcessUserDisconnectMessage()
        {
            string message = await ReadMessageBytes();
            Users.Items.Remove(message); // Remove user from list of users.
        }

        private async Task<string> ReadMessageBytes()
        {
            int x, size;
            byte[] sizeBytes = new byte[4];
            x = await stream.ReadAsync(sizeBytes, 0, sizeBytes.Length);
            size = BitConverter.ToInt32(sizeBytes, 0);
            byte[] buffer = new byte[size];
            string message = null;
            x = await stream.ReadAsync(buffer, 0, buffer.Length);
            message += Encoding.ASCII.GetString(buffer);
            return message;
        }
    }
}
