using System;
using System.Windows;
using CalculadoraWPF.Models;
using CalculadoraWPF.Services;

namespace CalculadoraWPF
{
    public partial class MainWindow : Window
    {
        private readonly CalculadoraBasica calc = new();
        private readonly OperacionesAvanzadas adv = new();
        private readonly IMCService imcService = new();

        public MainWindow()
        {
            InitializeComponent();
        }
private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double resultado = calc.EvaluarExpresion(txtExpresion.Text);

                txtResultado.Text = $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Potencia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double b = double.Parse(txtBase.Text);
                double eNum = double.Parse(txtExponente.Text);

                double resultado = adv.Potencia(b, eNum);

                txtPotenciaResultado.Text =
                    $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Raiz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero = double.Parse(txtRaiz.Text);

                double resultado = adv.RaizCuadrada(numero);

                txtRaizResultado.Text =
                    $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         private void IMC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Nombre = txtNombre.Text,
                    FechaNacimiento = dpFechaNacimiento.SelectedDate
                        ?? DateTime.Today
                };

                double peso = double.Parse(txtPeso.Text);
                double altura = double.Parse(txtAltura.Text);

                double imc = imcService.CalcularIMC(peso, altura);

                string categoria =
                    imcService.ObtenerCategoria(imc);

                txtIMCResultado.Text =
                    $"Nombre: {usuario.Nombre}\n" +
                    $"Edad: {usuario.CalcularEdad()} años\n" +
                    $"IMC: {imc:F2}\n" +
                    $"Estado: {categoria}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}