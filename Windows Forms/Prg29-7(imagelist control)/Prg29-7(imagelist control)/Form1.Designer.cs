namespace Prg29_7_imagelist_control_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("tree node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("form");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("account", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("register", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("parent node", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("rose");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("hibiscus");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("flower", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.png");
            this.imageList1.Images.SetKeyName(1, "flower.jpg");
            this.imageList1.Images.SetKeyName(2, "MKPITS_Logo.png");
            this.imageList1.Images.SetKeyName(3, "career.jpg");
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(207, 42);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "tree node";
            treeNode1.Text = "tree node";
            treeNode2.ImageKey = "MKPITS_Logo.png";
            treeNode2.Name = "form";
            treeNode2.Text = "form";
            treeNode3.ImageKey = "career.jpg";
            treeNode3.Name = "account";
            treeNode3.Text = "account";
            treeNode4.ImageKey = "flower.jpg";
            treeNode4.Name = "register";
            treeNode4.Text = "register";
            treeNode5.Name = "parent node";
            treeNode5.Text = "parent node";
            treeNode6.Name = "Node6";
            treeNode6.Text = "rose";
            treeNode7.ImageKey = "career.jpg";
            treeNode7.Name = "Node7";
            treeNode7.Text = "hibiscus";
            treeNode8.ImageKey = "MKPITS_Logo.png";
            treeNode8.Name = "Node5";
            treeNode8.Text = "flower";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode8});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(239, 215);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

