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

namespace REPASO3
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }
        void Leer()
        {
            FileStream stream = new FileStream("archivo1.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Propietario propietario = new Propietario();
                propietario.Dpi = Convert.ToInt32(reader.ReadLine());
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarios.Add(propietario);
            }
            reader.Close();
        }
        void Leer2()
        {
            FileStream stream = new FileStream("archivo2.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Propiedad propiedad = new Propiedad();
                propiedad.Dpi = Convert.ToInt32(reader.ReadLine());
                propiedad.Nocasa = Convert.ToInt32(reader.ReadLine());
                propiedad.Cuota = Convert.ToDouble(reader.ReadLine());
                propiedades.Add(propiedad);
            }
            reader.Close();
        }
        void Leer3()
        {
            FileStream stream = new FileStream("archivo3.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Reporte reporte = new Reporte();
                reporte.Nombre = reader.ReadLine();
                reporte.Apellido = reader.ReadLine();
                reporte.Nocasa = Convert.ToInt32(reader.ReadLine());
                reporte.Cuota = Convert.ToDouble(reader.ReadLine());
                reportes.Add(reporte);
            }
            reader.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Leer();
            Leer2();
            Leer3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propietarios.Count; i++)
            {
                Reporte reporte = new Reporte();
                for (int j = 0; j < propiedades.Count; j++)
                {
                    if (propietarios[i].Dpi == propiedades[j].Dpi)
                    {
                        reporte.Nombre = propietarios[i].Nombre;
                        reporte.Apellido = propietarios[i].Apellido;
                        reporte.Nocasa = propiedades[j].Nocasa;
                        reporte.Cuota = propiedades[j].Cuota;
                    }
                }
                reportes.Add(reporte);
            }
            Mostrar();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            reportes = reportes.OrderBy(p => p.Cuota).ToList();
            Mostrar();
        }

        private void buttonPropietario_Click(object sender, EventArgs e)
        {
            double mayor = reportes.Max(a=>a.Cuota);
            Reporte Mayor = reportes.OrderByDescending(b=>b.Cuota).First();
            MessageBox.Show("El propietario con más cuotas a deber es "+Mayor);
        }

        private void buttonCuotas_Click(object sender, EventArgs e)
        {
            double mayor = reportes.Max(a => a.Cuota);
            double min = reportes.Min(a => a.Cuota);
            MessageBox.Show("Las cuotas mayores son: "+mayor+" y las menores son: "+min);
        }
    }
    }
