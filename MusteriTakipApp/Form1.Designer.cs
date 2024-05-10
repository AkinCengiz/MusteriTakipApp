namespace MusteriTakipApp;

partial class Form1
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		gbxOgrenciEkle = new GroupBox();
		btnEkle = new Button();
		txtMusteriAdSoyad = new TextBox();
		txtMusteriNo = new TextBox();
		lblAdSoyad = new Label();
		lblMusteriNo = new Label();
		lbxMusteriler = new ListBox();
		gbxMusteriler = new GroupBox();
		gbxMusteriGuncelle = new GroupBox();
		btnSil = new Button();
		btnGuncelle = new Button();
		txtSecilenMusteriAdSoyad = new TextBox();
		txtSecilenMusteriNo = new TextBox();
		label1 = new Label();
		label2 = new Label();
		gbxOgrenciEkle.SuspendLayout();
		gbxMusteriler.SuspendLayout();
		gbxMusteriGuncelle.SuspendLayout();
		SuspendLayout();
		// 
		// gbxOgrenciEkle
		// 
		gbxOgrenciEkle.Controls.Add(btnEkle);
		gbxOgrenciEkle.Controls.Add(txtMusteriAdSoyad);
		gbxOgrenciEkle.Controls.Add(txtMusteriNo);
		gbxOgrenciEkle.Controls.Add(lblAdSoyad);
		gbxOgrenciEkle.Controls.Add(lblMusteriNo);
		gbxOgrenciEkle.Font = new Font("Segoe UI", 14.25F);
		gbxOgrenciEkle.Location = new Point(12, 12);
		gbxOgrenciEkle.Name = "gbxOgrenciEkle";
		gbxOgrenciEkle.Size = new Size(389, 187);
		gbxOgrenciEkle.TabIndex = 0;
		gbxOgrenciEkle.TabStop = false;
		gbxOgrenciEkle.Text = "Öğrenci Ekleme Paneli";
		// 
		// btnEkle
		// 
		btnEkle.Location = new Point(227, 110);
		btnEkle.Name = "btnEkle";
		btnEkle.Size = new Size(136, 34);
		btnEkle.TabIndex = 4;
		btnEkle.Text = "Kaydet";
		btnEkle.UseVisualStyleBackColor = true;
		btnEkle.Click += btnEkle_Click;
		// 
		// txtMusteriAdSoyad
		// 
		txtMusteriAdSoyad.Location = new Point(227, 71);
		txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
		txtMusteriAdSoyad.Size = new Size(136, 33);
		txtMusteriAdSoyad.TabIndex = 3;
		// 
		// txtMusteriNo
		// 
		txtMusteriNo.Location = new Point(227, 27);
		txtMusteriNo.Name = "txtMusteriNo";
		txtMusteriNo.Size = new Size(136, 33);
		txtMusteriNo.TabIndex = 2;
		// 
		// lblAdSoyad
		// 
		lblAdSoyad.AutoSize = true;
		lblAdSoyad.Font = new Font("Segoe UI", 14.25F);
		lblAdSoyad.Location = new Point(1, 74);
		lblAdSoyad.Name = "lblAdSoyad";
		lblAdSoyad.Size = new Size(208, 25);
		lblAdSoyad.TabIndex = 1;
		lblAdSoyad.Text = "Müşteri Adı ve Soyadı : ";
		// 
		// lblMusteriNo
		// 
		lblMusteriNo.AutoSize = true;
		lblMusteriNo.Font = new Font("Segoe UI", 14.25F);
		lblMusteriNo.Location = new Point(89, 30);
		lblMusteriNo.Name = "lblMusteriNo";
		lblMusteriNo.Size = new Size(120, 25);
		lblMusteriNo.TabIndex = 0;
		lblMusteriNo.Text = "Müşteri No : ";
		// 
		// lbxMusteriler
		// 
		lbxMusteriler.FormattingEnabled = true;
		lbxMusteriler.ItemHeight = 25;
		lbxMusteriler.Location = new Point(6, 32);
		lbxMusteriler.Name = "lbxMusteriler";
		lbxMusteriler.Size = new Size(246, 379);
		lbxMusteriler.TabIndex = 1;
		lbxMusteriler.SelectedIndexChanged += lbxMusteriler_SelectedIndexChanged;
		// 
		// gbxMusteriler
		// 
		gbxMusteriler.Controls.Add(lbxMusteriler);
		gbxMusteriler.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
		gbxMusteriler.Location = new Point(410, 12);
		gbxMusteriler.Name = "gbxMusteriler";
		gbxMusteriler.Size = new Size(258, 426);
		gbxMusteriler.TabIndex = 2;
		gbxMusteriler.TabStop = false;
		gbxMusteriler.Text = "Müşteri Listesi";
		// 
		// gbxMusteriGuncelle
		// 
		gbxMusteriGuncelle.Controls.Add(btnSil);
		gbxMusteriGuncelle.Controls.Add(btnGuncelle);
		gbxMusteriGuncelle.Controls.Add(txtSecilenMusteriAdSoyad);
		gbxMusteriGuncelle.Controls.Add(txtSecilenMusteriNo);
		gbxMusteriGuncelle.Controls.Add(label1);
		gbxMusteriGuncelle.Controls.Add(label2);
		gbxMusteriGuncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
		gbxMusteriGuncelle.Location = new Point(13, 205);
		gbxMusteriGuncelle.Name = "gbxMusteriGuncelle";
		gbxMusteriGuncelle.Size = new Size(388, 233);
		gbxMusteriGuncelle.TabIndex = 3;
		gbxMusteriGuncelle.TabStop = false;
		gbxMusteriGuncelle.Text = "Musteri Silme ve Güncelleme Paneli";
		// 
		// btnSil
		// 
		btnSil.Location = new Point(226, 155);
		btnSil.Name = "btnSil";
		btnSil.Size = new Size(136, 34);
		btnSil.TabIndex = 10;
		btnSil.Text = "Sil";
		btnSil.UseVisualStyleBackColor = true;
		btnSil.Click += btnSil_Click;
		// 
		// btnGuncelle
		// 
		btnGuncelle.Location = new Point(226, 115);
		btnGuncelle.Name = "btnGuncelle";
		btnGuncelle.Size = new Size(136, 34);
		btnGuncelle.TabIndex = 9;
		btnGuncelle.Text = "Güncelle";
		btnGuncelle.UseVisualStyleBackColor = true;
		btnGuncelle.Click += btnGuncelle_Click;
		// 
		// txtSecilenMusteriAdSoyad
		// 
		txtSecilenMusteriAdSoyad.Location = new Point(226, 76);
		txtSecilenMusteriAdSoyad.Name = "txtSecilenMusteriAdSoyad";
		txtSecilenMusteriAdSoyad.Size = new Size(136, 33);
		txtSecilenMusteriAdSoyad.TabIndex = 8;
		// 
		// txtSecilenMusteriNo
		// 
		txtSecilenMusteriNo.Location = new Point(226, 32);
		txtSecilenMusteriNo.Name = "txtSecilenMusteriNo";
		txtSecilenMusteriNo.Size = new Size(136, 33);
		txtSecilenMusteriNo.TabIndex = 7;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI", 14.25F);
		label1.Location = new Point(0, 79);
		label1.Name = "label1";
		label1.Size = new Size(208, 25);
		label1.TabIndex = 6;
		label1.Text = "Müşteri Adı ve Soyadı : ";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI", 14.25F);
		label2.Location = new Point(88, 35);
		label2.Name = "label2";
		label2.Size = new Size(120, 25);
		label2.TabIndex = 5;
		label2.Text = "Müşteri No : ";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(gbxMusteriGuncelle);
		Controls.Add(gbxMusteriler);
		Controls.Add(gbxOgrenciEkle);
		Name = "Form1";
		Text = "Form1";
		Load += Form1_Load;
		gbxOgrenciEkle.ResumeLayout(false);
		gbxOgrenciEkle.PerformLayout();
		gbxMusteriler.ResumeLayout(false);
		gbxMusteriGuncelle.ResumeLayout(false);
		gbxMusteriGuncelle.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private GroupBox gbxOgrenciEkle;
	private TextBox txtMusteriAdSoyad;
	private TextBox txtMusteriNo;
	private Label lblAdSoyad;
	private Label lblMusteriNo;
	private Button btnEkle;
	private ListBox lbxMusteriler;
	private GroupBox gbxMusteriler;
	private GroupBox gbxMusteriGuncelle;
	private Button btnSil;
	private Button btnGuncelle;
	private TextBox txtSecilenMusteriAdSoyad;
	private TextBox txtSecilenMusteriNo;
	private Label label1;
	private Label label2;
}
