using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WKSaveEditorr {
    public partial class Form1 : Form {
        private string currentFilePath;
        private JObject jsonObject;
        private JValue originalValue;
        private bool Edited = false;
        public Form1() {
            InitializeComponent();
            TreeView.LabelEdit = true;
            TreeView.BeforeLabelEdit += BeforeNodeEdit;
            TreeView.AfterLabelEdit += OnNodeEdited;
            this.FormClosing += Form1_FormClosing;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            FillTree("controls.res");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (!Edited) return;
            DialogResult result = MessageBox.Show(
                "You have unsaved changes. Do you want to save before exiting?",
                "Unsaved Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel) {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes) {
                NotOpenDialog = true;
                SaveButton_Click(sender, e);
                NotOpenDialog = false;
            }
            else if (result == DialogResult.No) {
                e.Cancel = false;
            }
        }
        private void PopulateTreeView(JToken token, TreeNodeCollection nodes) {
            if (token is JProperty prop) {
                TreeNode node = nodes.Add(prop.Name);
                node.Tag = prop;
                PopulateTreeView(prop.Value, node.Nodes);
            }
            else if (token is JObject obj) {
                foreach (var property in obj.Properties())
                    PopulateTreeView(property, nodes);
            }
            else if (token is JArray array) {
                for (int i = 0; i < array.Count; i++) {
                    TreeNode node = nodes.Add($"[{i}]");
                    node.Tag = array[i]; 
                    PopulateTreeView(array[i], node.Nodes);
                }
            }
            else {
                nodes.Add(token.ToString()).Tag = token;
            }
        }

        private void BeforeNodeEdit(object sender, NodeLabelEditEventArgs e) {
            if ((e.Node.Tag is JValue jValue)) {
                Console.WriteLine(jValue.GetType());
                originalValue = jValue;
            }
            else {
                Console.WriteLine(e.Node.Tag.GetType());
                e.CancelEdit = true;
            }
        }

        private void OnNodeEdited(object sender, NodeLabelEditEventArgs e) {
            Console.WriteLine(e.Node.Tag);
            if (e.Node.Tag is JValue jValue) {

                // If originally an int
                if (int.TryParse(originalValue.ToString(Newtonsoft.Json.Formatting.None), out int originalIntValue)) {

                    Console.WriteLine("Original value is int");
                    if (int.TryParse(e.Label, out int newIntValue)) {
                        Console.WriteLine("New value is int");
                        jValue.Value = (new JValue(newIntValue)).Value;
                        Edited = true;
                    }
                    else {
                        if (e.Label != null) {
                            Console.WriteLine(originalValue);
                            Console.WriteLine(e.Label);
                            MessageBox.Show("Invalid input! Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.CancelEdit = true;
                            return;
                        }
                    }
                }
                // If originally a bool
                else if (bool.TryParse(originalValue.ToString(Newtonsoft.Json.Formatting.None), out bool originalBoolValue)) {

                    Console.WriteLine("Original value is bool");
                    if (bool.TryParse(e.Label, out bool newBoolValue)) {
                        Console.WriteLine("New value is bool");
                        jValue.Value = (new JValue(newBoolValue)).Value;
                        Edited = true;
                    }
                    else {
                        if (e.Label != null) {
                            Console.WriteLine(originalValue);
                            Console.WriteLine(e.Label);
                            MessageBox.Show("Invalid input! Please enter 'true' or 'false'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.CancelEdit = true;
                            return;
                        }
                    }
                }
                else if (double.TryParse(originalValue.ToString(Newtonsoft.Json.Formatting.None), out double originalDoubleValue)) {
                    Console.WriteLine("Original value is double");
                    if (double.TryParse(e.Label, out double newDoubleValue)) {
                        Console.WriteLine("New value is double");
                        jValue.Value = (new JValue(newDoubleValue)).Value;
                        Edited = true;
                    }
                    else {
                        if (e.Label != null) {
                            Console.WriteLine(originalValue);
                            Console.WriteLine(e.Label);
                            MessageBox.Show("Invalid input! Please enter a double.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.CancelEdit = true;
                            return;
                        }
                    }
                }
                else if (float.TryParse(originalValue.ToString(Newtonsoft.Json.Formatting.None), out float originalFloatValue)) {
                    Console.WriteLine("Original value is float");
                    if (float.TryParse(e.Label, out float newFloatValue)) {
                        Console.WriteLine("New value is float");
                        jValue.Value = (new JValue(newFloatValue)).Value;
                        Edited = true;
                    }
                    else {
                        if (e.Label != null) {
                            Console.WriteLine(originalValue);
                            Console.WriteLine(e.Label);
                            MessageBox.Show("Invalid input! Please enter a float.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.CancelEdit = true;
                            return;
                        }
                    }
                }
                else if (decimal.TryParse(originalValue.ToString(Newtonsoft.Json.Formatting.None), out decimal originalDecimalValue)) {
                    Console.WriteLine("Original value is decimal");
                    if (decimal.TryParse(e.Label, out decimal newDecimalValue)) {
                        Console.WriteLine("New value is decimal");
                        jValue.Value = (new JValue(newDecimalValue)).Value;
                        Edited = true;
                    }
                    else {
                        if (e.Label != null) {
                            Console.WriteLine(originalValue);
                            Console.WriteLine(e.Label);
                            MessageBox.Show("Invalid input! Please enter a decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.CancelEdit = true;
                            return;
                        }
                    }
                }
                else {
                    Console.WriteLine("Original value is string");
                    jValue.Value = e.Label;
                }

                e.Node.Tag = jValue;
            }
        }
        private void LoadedFileTabs_SelectedIndexChanged(object sender, EventArgs e) {
            if (LoadedFileTabs.SelectedTab == ControlslTab)    FillTree("controls.res");
            else if (LoadedFileTabs.SelectedTab == PlayerTab)  FillTree("player.res");
            else if (LoadedFileTabs.SelectedTab == PlayersTab) FillTree("players.res");
            else if (LoadedFileTabs.SelectedTab == SaveTab)    FillTree("save.res");
            else if (LoadedFileTabs.SelectedTab == StatsTab)   FillTree("stats.res");
            else if (LoadedFileTabs.SelectedTab == UnlocksTab) FillTree("unlocks.res");
            else if (LoadedFileTabs.SelectedTab == OptionsTab) FillTree("windowkill_data.res");
        }

        private void FillTree(string fileName) {
            if (Edited) {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save before loading a new file?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel) {
                    return;
                }
                else if (result == DialogResult.Yes) {
                    NotOpenDialog = true;
                    SaveButton_Click(null, null);
                    NotOpenDialog = false;
                }
            }
            Edited = false;
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            currentFilePath = appDataPath + "/Godot/app_userdata/windowkill/" + fileName;
            string json = File.ReadAllText(currentFilePath);
            jsonObject = JObject.Parse(json);
            TreeView.Nodes.Clear();
            PopulateTreeView(jsonObject, TreeView.Nodes);
            ExpandNodes.Checked = false;
            ExpandNodes.CheckState = CheckState.Unchecked;
        }
        private bool NotOpenDialog = false;
        private void SaveButton_Click(object sender, EventArgs e) {
            if (jsonObject == null) {
                MessageBox.Show("No JSON file loaded. Please load a file first.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(currentFilePath)) {
                string updatedJson = jsonObject.ToString(Newtonsoft.Json.Formatting.None);
                updatedJson = updatedJson.Replace("\r\n", "\n").Replace("\r", "\n");
                //updatedJson = updatedJson.Replace("\\\"", "");

                File.WriteAllText(currentFilePath, updatedJson);
                Edited = false;
                if (!NotOpenDialog)
                MessageBox.Show("JSON saved!", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("No file path available. Please load a file first.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            Console.WriteLine(e.Node.Tag);

        }

        private void ReloadFileButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to reload the file?",
                "Reload?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            if (result == DialogResult.OK) {
                Edited = false;
                FillTree(currentFilePath.Split('/').Last());
            }
        }

        private void ExpandNodes_CheckedChanged(object sender, EventArgs e) {
            if (justExpanded) {
                justExpanded = false;
                return;
            }
            if (ExpandNodes.Checked) {
                foreach (TreeNode node in TreeView.Nodes) {
                    node.ExpandAll();
                    ExpandNodes.CheckState = CheckState.Checked;
                }
            }
            else {
                foreach (TreeNode node in TreeView.Nodes) {
                    node.Collapse();
                    ExpandNodes.CheckState = CheckState.Unchecked;
                }
            }
        }
        private bool justExpanded = false;
        private void TreeView_AfterExpand(object sender, TreeViewEventArgs e) {
            justExpanded = true;
            ExpandNodes.CheckState = CheckState.Indeterminate;
            justExpanded = false;
        }

        private void TreeView_AfterCollapse(object sender, TreeViewEventArgs e) {
            justExpanded = true;
            ExpandNodes.CheckState = CheckState.Indeterminate;
            justExpanded = false;
        }
    }
}
