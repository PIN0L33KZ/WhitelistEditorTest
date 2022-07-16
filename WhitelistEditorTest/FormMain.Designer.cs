namespace WhitelistEditorTest
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BorderManager = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.TitelBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.WindowTitle = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TextBoxPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.DataGridWhitelist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Playername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripDatagrid = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.RemovePlayerFromListToolStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonExportWhitelist = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonSaveWhitelist = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonLoadWhitelist = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ButtonAddPlayer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TitelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWhitelist)).BeginInit();
            this.ContextMenuStripDatagrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderManager
            // 
            this.BorderManager.AnimateWindow = true;
            this.BorderManager.AnimationInterval = 250;
            this.BorderManager.ContainerControl = this;
            this.BorderManager.DockIndicatorTransparencyValue = 0.6D;
            this.BorderManager.DragForm = false;
            this.BorderManager.ResizeForm = false;
            this.BorderManager.TransparentWhileDrag = true;
            // 
            // TitelBar
            // 
            this.TitelBar.Controls.Add(this.MinimizeButton);
            this.TitelBar.Controls.Add(this.ExitButton);
            this.TitelBar.Controls.Add(this.WindowTitle);
            this.TitelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitelBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TitelBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TitelBar.Location = new System.Drawing.Point(0, 0);
            this.TitelBar.Name = "TitelBar";
            this.TitelBar.Size = new System.Drawing.Size(658, 33);
            this.TitelBar.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.Animated = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(587, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(31, 29);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseTransparentBackground = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Animated = true;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.ExitButton.FillColor = System.Drawing.Color.Transparent;
            this.ExitButton.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(624, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseTransparentBackground = true;
            // 
            // WindowTitle
            // 
            this.WindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowTitle.BackColor = System.Drawing.Color.Transparent;
            this.WindowTitle.ForeColor = System.Drawing.Color.White;
            this.WindowTitle.Location = new System.Drawing.Point(3, 0);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(652, 33);
            this.WindowTitle.TabIndex = 0;
            this.WindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.WindowTitle;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxPlayerName.Animated = true;
            this.TextBoxPlayerName.AutoRoundedCorners = true;
            this.TextBoxPlayerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.TextBoxPlayerName.BorderRadius = 17;
            this.TextBoxPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPlayerName.DefaultText = "";
            this.TextBoxPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.TextBoxPlayerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.TextBoxPlayerName.Location = new System.Drawing.Point(157, 58);
            this.TextBoxPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxPlayerName.MaxLength = 225;
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.PasswordChar = '\0';
            this.TextBoxPlayerName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBoxPlayerName.PlaceholderText = "Spielername";
            this.TextBoxPlayerName.SelectedText = "";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(206, 36);
            this.TextBoxPlayerName.TabIndex = 2;
            this.TextBoxPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPlayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPlayerName_KeyDown);
            // 
            // Separator1
            // 
            this.Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.Separator1.Location = new System.Drawing.Point(7, 109);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(643, 10);
            this.Separator1.TabIndex = 4;
            this.Separator1.UseTransparentBackground = true;
            // 
            // DataGridWhitelist
            // 
            this.DataGridWhitelist.AllowUserToAddRows = false;
            this.DataGridWhitelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridWhitelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridWhitelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridWhitelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridWhitelist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.DataGridWhitelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridWhitelist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridWhitelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridWhitelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridWhitelist.ColumnHeadersHeight = 22;
            this.DataGridWhitelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Playername,
            this.PlayerID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(143)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridWhitelist.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridWhitelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridWhitelist.EnableHeadersVisualStyles = false;
            this.DataGridWhitelist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridWhitelist.Location = new System.Drawing.Point(12, 135);
            this.DataGridWhitelist.Name = "DataGridWhitelist";
            this.DataGridWhitelist.ReadOnly = true;
            this.DataGridWhitelist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridWhitelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridWhitelist.RowHeadersVisible = false;
            this.DataGridWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridWhitelist.Size = new System.Drawing.Size(634, 298);
            this.DataGridWhitelist.TabIndex = 5;
            this.DataGridWhitelist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.DataGridWhitelist.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridWhitelist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridWhitelist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.DataGridWhitelist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridWhitelist.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.DataGridWhitelist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridWhitelist.ThemeStyle.HeaderStyle.Height = 22;
            this.DataGridWhitelist.ThemeStyle.ReadOnly = true;
            this.DataGridWhitelist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.DataGridWhitelist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridWhitelist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridWhitelist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridWhitelist.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridWhitelist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.DataGridWhitelist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Playername
            // 
            this.Playername.HeaderText = "Spielername";
            this.Playername.Name = "Playername";
            this.Playername.ReadOnly = true;
            // 
            // PlayerID
            // 
            this.PlayerID.HeaderText = "UUID";
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            // 
            // ContextMenuStripDatagrid
            // 
            this.ContextMenuStripDatagrid.BackColor = System.Drawing.Color.White;
            this.ContextMenuStripDatagrid.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuStripDatagrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemovePlayerFromListToolStripButton});
            this.ContextMenuStripDatagrid.Name = "ContextMenuStripDatagrid";
            this.ContextMenuStripDatagrid.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ContextMenuStripDatagrid.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.ContextMenuStripDatagrid.RenderStyle.ColorTable = null;
            this.ContextMenuStripDatagrid.RenderStyle.RoundedEdges = true;
            this.ContextMenuStripDatagrid.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStripDatagrid.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ContextMenuStripDatagrid.RenderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContextMenuStripDatagrid.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ContextMenuStripDatagrid.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStripDatagrid.Size = new System.Drawing.Size(248, 28);
            // 
            // RemovePlayerFromListToolStripButton
            // 
            this.RemovePlayerFromListToolStripButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePlayerFromListToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RemovePlayerFromListToolStripButton.Name = "RemovePlayerFromListToolStripButton";
            this.RemovePlayerFromListToolStripButton.Size = new System.Drawing.Size(247, 24);
            this.RemovePlayerFromListToolStripButton.Text = "Freischaltung aufheben";
            this.RemovePlayerFromListToolStripButton.Click += new System.EventHandler(this.RemovePlayerFromListToolStripButton_Click);
            // 
            // ButtonExportWhitelist
            // 
            this.ButtonExportWhitelist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonExportWhitelist.Animated = true;
            this.ButtonExportWhitelist.AutoRoundedCorners = true;
            this.ButtonExportWhitelist.BorderRadius = 17;
            this.ButtonExportWhitelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExportWhitelist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ButtonExportWhitelist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonExportWhitelist.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonExportWhitelist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonExportWhitelist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ButtonExportWhitelist.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ButtonExportWhitelist.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExportWhitelist.ForeColor = System.Drawing.Color.White;
            this.ButtonExportWhitelist.Image = global::WhitelistEditorTest.Properties.Resources.export_to_file;
            this.ButtonExportWhitelist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonExportWhitelist.Location = new System.Drawing.Point(511, 439);
            this.ButtonExportWhitelist.Name = "ButtonExportWhitelist";
            this.ButtonExportWhitelist.Size = new System.Drawing.Size(135, 36);
            this.ButtonExportWhitelist.TabIndex = 7;
            this.ButtonExportWhitelist.Text = "Exportieren";
            this.ButtonExportWhitelist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonExportWhitelist.Click += new System.EventHandler(this.ButtonExportWhitelist_Click);
            // 
            // ButtonSaveWhitelist
            // 
            this.ButtonSaveWhitelist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSaveWhitelist.Animated = true;
            this.ButtonSaveWhitelist.AutoRoundedCorners = true;
            this.ButtonSaveWhitelist.BorderRadius = 17;
            this.ButtonSaveWhitelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSaveWhitelist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ButtonSaveWhitelist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonSaveWhitelist.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonSaveWhitelist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSaveWhitelist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ButtonSaveWhitelist.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ButtonSaveWhitelist.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveWhitelist.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveWhitelist.Image = global::WhitelistEditorTest.Properties.Resources.save_to_file;
            this.ButtonSaveWhitelist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonSaveWhitelist.Location = new System.Drawing.Point(109, 439);
            this.ButtonSaveWhitelist.Name = "ButtonSaveWhitelist";
            this.ButtonSaveWhitelist.Size = new System.Drawing.Size(121, 36);
            this.ButtonSaveWhitelist.TabIndex = 7;
            this.ButtonSaveWhitelist.Text = "Speichern";
            this.ButtonSaveWhitelist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonSaveWhitelist.Click += new System.EventHandler(this.ButtonSaveWhitelist_Click);
            // 
            // ButtonLoadWhitelist
            // 
            this.ButtonLoadWhitelist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonLoadWhitelist.Animated = true;
            this.ButtonLoadWhitelist.AutoRoundedCorners = true;
            this.ButtonLoadWhitelist.BorderRadius = 17;
            this.ButtonLoadWhitelist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoadWhitelist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ButtonLoadWhitelist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonLoadWhitelist.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonLoadWhitelist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonLoadWhitelist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ButtonLoadWhitelist.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ButtonLoadWhitelist.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoadWhitelist.ForeColor = System.Drawing.Color.White;
            this.ButtonLoadWhitelist.Image = global::WhitelistEditorTest.Properties.Resources.load_from_file;
            this.ButtonLoadWhitelist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonLoadWhitelist.Location = new System.Drawing.Point(12, 439);
            this.ButtonLoadWhitelist.Name = "ButtonLoadWhitelist";
            this.ButtonLoadWhitelist.Size = new System.Drawing.Size(91, 36);
            this.ButtonLoadWhitelist.TabIndex = 7;
            this.ButtonLoadWhitelist.Text = "Laden";
            this.ButtonLoadWhitelist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonLoadWhitelist.Click += new System.EventHandler(this.ButtonLoadWhitelist_Click);
            // 
            // ButtonAddPlayer
            // 
            this.ButtonAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAddPlayer.Animated = true;
            this.ButtonAddPlayer.AutoRoundedCorners = true;
            this.ButtonAddPlayer.BorderRadius = 17;
            this.ButtonAddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddPlayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ButtonAddPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonAddPlayer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ButtonAddPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddPlayer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ButtonAddPlayer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ButtonAddPlayer.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPlayer.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPlayer.Image = global::WhitelistEditorTest.Properties.Resources.grant_access;
            this.ButtonAddPlayer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonAddPlayer.Location = new System.Drawing.Point(370, 58);
            this.ButtonAddPlayer.Name = "ButtonAddPlayer";
            this.ButtonAddPlayer.Size = new System.Drawing.Size(134, 36);
            this.ButtonAddPlayer.TabIndex = 3;
            this.ButtonAddPlayer.Text = "Freischalten";
            this.ButtonAddPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonAddPlayer.Click += new System.EventHandler(this.ButtonAddPlayer_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 483);
            this.Controls.Add(this.ButtonExportWhitelist);
            this.Controls.Add(this.ButtonSaveWhitelist);
            this.Controls.Add(this.ButtonLoadWhitelist);
            this.Controls.Add(this.DataGridWhitelist);
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.ButtonAddPlayer);
            this.Controls.Add(this.TextBoxPlayerName);
            this.Controls.Add(this.TitelBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Freischaltungen verwalten";
            this.TitelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWhitelist)).EndInit();
            this.ContextMenuStripDatagrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderManager;
        private Guna.UI2.WinForms.Guna2GradientPanel TitelBar;
        private System.Windows.Forms.Label WindowTitle;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPlayerName;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonAddPlayer;
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridWhitelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Playername;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStripDatagrid;
        private System.Windows.Forms.ToolStripMenuItem RemovePlayerFromListToolStripButton;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonSaveWhitelist;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonLoadWhitelist;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonExportWhitelist;
    }
}

