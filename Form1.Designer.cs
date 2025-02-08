namespace WKSaveEditorr {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode12});
            this.TreeView = new System.Windows.Forms.TreeView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReloadFileButton = new System.Windows.Forms.Button();
            this.LoadedFileTabs = new System.Windows.Forms.TabControl();
            this.ControlslTab = new System.Windows.Forms.TabPage();
            this.PlayerTab = new System.Windows.Forms.TabPage();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.SaveTab = new System.Windows.Forms.TabPage();
            this.StatsTab = new System.Windows.Forms.TabPage();
            this.UnlocksTab = new System.Windows.Forms.TabPage();
            this.OptionsTab = new System.Windows.Forms.TabPage();
            this.ExpandNodes = new System.Windows.Forms.CheckBox();
            this.LoadedFileTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.Indent = 10;
            this.TreeView.ItemHeight = 14;
            this.TreeView.LabelEdit = true;
            this.TreeView.Location = new System.Drawing.Point(12, 31);
            this.TreeView.Name = "TreeView";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Node4";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Node1";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Node2";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Node5";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Node9";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Node10";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Node11";
            treeNode11.Name = "Node12";
            treeNode11.Text = "Node12";
            treeNode12.Name = "Node8";
            treeNode12.Text = "Node8";
            treeNode13.Name = "Node6";
            treeNode13.Text = "Node6";
            this.TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode13});
            this.TreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TreeView.Size = new System.Drawing.Size(479, 475);
            this.TreeView.TabIndex = 0;
            this.TreeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterCollapse);
            this.TreeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterExpand);
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(416, 515);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save to file";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReloadFileButton
            // 
            this.ReloadFileButton.Location = new System.Drawing.Point(335, 515);
            this.ReloadFileButton.Name = "ReloadFileButton";
            this.ReloadFileButton.Size = new System.Drawing.Size(75, 23);
            this.ReloadFileButton.TabIndex = 8;
            this.ReloadFileButton.Text = "Reload file";
            this.ReloadFileButton.UseVisualStyleBackColor = true;
            this.ReloadFileButton.Click += new System.EventHandler(this.ReloadFileButton_Click);
            // 
            // LoadedFileTabs
            // 
            this.LoadedFileTabs.Controls.Add(this.ControlslTab);
            this.LoadedFileTabs.Controls.Add(this.PlayerTab);
            this.LoadedFileTabs.Controls.Add(this.PlayersTab);
            this.LoadedFileTabs.Controls.Add(this.SaveTab);
            this.LoadedFileTabs.Controls.Add(this.StatsTab);
            this.LoadedFileTabs.Controls.Add(this.UnlocksTab);
            this.LoadedFileTabs.Controls.Add(this.OptionsTab);
            this.LoadedFileTabs.ItemSize = new System.Drawing.Size(55, 18);
            this.LoadedFileTabs.Location = new System.Drawing.Point(12, 12);
            this.LoadedFileTabs.Name = "LoadedFileTabs";
            this.LoadedFileTabs.Padding = new System.Drawing.Point(3, 3);
            this.LoadedFileTabs.SelectedIndex = 0;
            this.LoadedFileTabs.Size = new System.Drawing.Size(479, 19);
            this.LoadedFileTabs.TabIndex = 9;
            this.LoadedFileTabs.SelectedIndexChanged += new System.EventHandler(this.LoadedFileTabs_SelectedIndexChanged);
            // 
            // ControlslTab
            // 
            this.ControlslTab.Location = new System.Drawing.Point(4, 22);
            this.ControlslTab.Name = "ControlslTab";
            this.ControlslTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlslTab.Size = new System.Drawing.Size(471, 0);
            this.ControlslTab.TabIndex = 0;
            this.ControlslTab.Text = "Controls";
            this.ControlslTab.UseVisualStyleBackColor = true;
            // 
            // PlayerTab
            // 
            this.PlayerTab.Location = new System.Drawing.Point(4, 22);
            this.PlayerTab.Name = "PlayerTab";
            this.PlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayerTab.Size = new System.Drawing.Size(471, 0);
            this.PlayerTab.TabIndex = 1;
            this.PlayerTab.Text = "Player";
            this.PlayerTab.UseVisualStyleBackColor = true;
            // 
            // PlayersTab
            // 
            this.PlayersTab.Location = new System.Drawing.Point(4, 22);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Size = new System.Drawing.Size(471, 0);
            this.PlayersTab.TabIndex = 2;
            this.PlayersTab.Text = "Players";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // SaveTab
            // 
            this.SaveTab.Location = new System.Drawing.Point(4, 22);
            this.SaveTab.Name = "SaveTab";
            this.SaveTab.Size = new System.Drawing.Size(471, 0);
            this.SaveTab.TabIndex = 3;
            this.SaveTab.Text = "Save";
            this.SaveTab.UseVisualStyleBackColor = true;
            // 
            // StatsTab
            // 
            this.StatsTab.Location = new System.Drawing.Point(4, 22);
            this.StatsTab.Name = "StatsTab";
            this.StatsTab.Size = new System.Drawing.Size(471, 0);
            this.StatsTab.TabIndex = 4;
            this.StatsTab.Text = "Stats";
            this.StatsTab.UseVisualStyleBackColor = true;
            // 
            // UnlocksTab
            // 
            this.UnlocksTab.Location = new System.Drawing.Point(4, 22);
            this.UnlocksTab.Name = "UnlocksTab";
            this.UnlocksTab.Size = new System.Drawing.Size(471, 0);
            this.UnlocksTab.TabIndex = 5;
            this.UnlocksTab.Text = "Unlocks";
            this.UnlocksTab.UseVisualStyleBackColor = true;
            // 
            // OptionsTab
            // 
            this.OptionsTab.Location = new System.Drawing.Point(4, 22);
            this.OptionsTab.Name = "OptionsTab";
            this.OptionsTab.Size = new System.Drawing.Size(471, 0);
            this.OptionsTab.TabIndex = 6;
            this.OptionsTab.Text = "Options";
            this.OptionsTab.UseVisualStyleBackColor = true;
            // 
            // ExpandNodes
            // 
            this.ExpandNodes.AutoSize = true;
            this.ExpandNodes.Location = new System.Drawing.Point(12, 520);
            this.ExpandNodes.Name = "ExpandNodes";
            this.ExpandNodes.Size = new System.Drawing.Size(119, 17);
            this.ExpandNodes.TabIndex = 10;
            this.ExpandNodes.Text = "All nodes expanded";
            this.ExpandNodes.UseVisualStyleBackColor = true;
            this.ExpandNodes.CheckedChanged += new System.EventHandler(this.ExpandNodes_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(503, 544);
            this.Controls.Add(this.ExpandNodes);
            this.Controls.Add(this.LoadedFileTabs);
            this.Controls.Add(this.ReloadFileButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TreeView);
            this.Name = "Form1";
            this.Text = "Windowkill save editor";
            this.LoadedFileTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReloadFileButton;
        private System.Windows.Forms.TabControl LoadedFileTabs;
        private System.Windows.Forms.TabPage ControlslTab;
        private System.Windows.Forms.TabPage PlayerTab;
        private System.Windows.Forms.TabPage PlayersTab;
        private System.Windows.Forms.TabPage SaveTab;
        private System.Windows.Forms.TabPage StatsTab;
        private System.Windows.Forms.TabPage UnlocksTab;
        private System.Windows.Forms.TabPage OptionsTab;
        private System.Windows.Forms.CheckBox ExpandNodes;
    }
}

