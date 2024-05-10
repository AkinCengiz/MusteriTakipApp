namespace MusteriTakipApp;

public partial class Form1 : Form
{
	Dictionary<string, string> _musteriBilgieri = new Dictionary<string, string>();
	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}

	private void btnEkle_Click(object sender, EventArgs e)
	{
		Random rnd = new Random();
		int sayi = rnd.Next(1, 2000);

		string musteriNo = sayi.ToString();
		string adSoyad = txtMusteriAdSoyad.Text;

		if (_musteriBilgieri.ContainsKey(musteriNo))
		{
			MessageBox.Show("Bu öðrenci numarasý zaten mevcut.");
			return;
		}
		_musteriBilgieri.Add(musteriNo, adSoyad);
		lbxMusteriler.Items.Add(musteriNo + " - " + adSoyad);
		Temizle();
	}

	public void Temizle()
	{
		txtMusteriAdSoyad.Clear();
		txtMusteriNo.Clear();
		txtMusteriNo.Focus();
		txtSecilenMusteriNo.Clear();
		txtSecilenMusteriAdSoyad.Clear();
	}

	private void lbxMusteriler_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (lbxMusteriler.SelectedIndex == -1) return;

		string secilenMusteri = lbxMusteriler.SelectedItem.ToString();
		string secilenNo = secilenMusteri.Split('-')[0].Trim();
		string secilenAdSoyad = secilenMusteri.Split('-')[1].Trim();
		txtSecilenMusteriNo.Text = secilenNo;
		txtSecilenMusteriAdSoyad.Text = secilenAdSoyad;
	}

	private void btnGuncelle_Click(object sender, EventArgs e)
	{
		_musteriBilgieri[txtSecilenMusteriNo.Text] = txtSecilenMusteriAdSoyad.Text;
		lbxMusteriler.Items[lbxMusteriler.SelectedIndex] = txtSecilenMusteriNo.Text + " - " + txtSecilenMusteriAdSoyad.Text;
		Temizle();
	}

	private void btnSil_Click(object sender, EventArgs e)
	{
		lbxMusteriler.Items.Remove(lbxMusteriler.SelectedItem);
		Temizle();
	}
}
