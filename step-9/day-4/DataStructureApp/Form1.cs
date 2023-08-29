using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureApp
{
    public partial class Form1 : Form
    {
        private Stack<string> stack = new Stack<string>();
        private Queue<string> queue = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stackListBox1.Items.Add("Item 1");
            stackListBox1.Items.Add("Item 2");
            stackListBox1.Items.Add("Item 3");

            queueListBox1.Items.Add("Item 1");
            queueListBox1.Items.Add("Item 2");
            queueListBox1.Items.Add("Item 3");
        }

        private void StackTransferButton_Click(object sender, EventArgs e)
        {
            ListBox sourceListBox, destinationListBox;

            if (sender == downBtn)
            {
                sourceListBox = stackListBox1;
                destinationListBox = stackListBox2;
            }
            else if (sender == upBtn)
            {
                sourceListBox = stackListBox2;
                destinationListBox = stackListBox1;
            }
            else
            {
                return;
            }

            if (sourceListBox.SelectedItem != null)
            {
                string selectedItem = sourceListBox.SelectedItem.ToString();
                sourceListBox.Items.Remove(selectedItem);
                destinationListBox.Items.Insert(0, selectedItem);

                if (sender == downBtn)
                {
                    stack.Push(selectedItem);
                }
                else if (sender == upBtn)
                {
                    if (stack.Count > 0)
                    {
                        string poppedItem = stack.Pop();
                        if (poppedItem != selectedItem)
                        {
                            stack.Push(poppedItem);
                        }
                    }
                }
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            ListBox sourceListBox, destinationListBox;

            if (sender == enqueueBtn)
            {
                sourceListBox = queueListBox1;
                destinationListBox = queueListBox2;
            }
            else if (sender == dequeueBtn)
            {
                sourceListBox = queueListBox2;
                destinationListBox = queueListBox1;
            }
            else
            {
                return;
            }

            if (sourceListBox.Items.Count > 0)
            {
                string itemToTransfer = sourceListBox.Items[0].ToString();
                sourceListBox.Items.RemoveAt(0);
                destinationListBox.Items.Add(itemToTransfer);

                if (sender == enqueueBtn)
                {
                    queue.Enqueue(itemToTransfer);
                }
                else if (sender == dequeueBtn)
                {
                    if (queue.Count > 0)
                    {
                        string dequeuedItem = queue.Dequeue();
                        if (dequeuedItem != itemToTransfer)
                        {
                            queue.Enqueue(dequeuedItem);
                        }
                    }
                }
            }
        }
    }

    public class PlateInfo
    {
        public string TypeName { get; set; }
        public int Quantity { get; set; }
    }
}
