Claro, Raíssa. Aqui está o mesmo código, **sem comentários** e limpo, pronto para usar no seu projeto:

```csharp
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace provaraissa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 5];
            string[] cursos = { "ADS", "Engenharia de Software" };
            string[] anos = { "2019", "2020", "2021", "2022", "2023" };

            listaDados.Items.Clear();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string entrada = Interaction.InputBox(
                        $"Digite o total de alunos do curso {cursos[i]} no ano {anos[j]}:",
                        "Entrada de dados"
                    );

                    int valor;
                    if (!int.TryParse(entrada, out valor))
                        valor = 0;

                    matriz[i, j] = valor;

                    listaDados.Items.Add(
                        $"Total de alunos do curso {cursos[i]} no ano {anos[j]}: {matriz[i, j]}"
                    );
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaDados.Items.Clear();
        }
    }
}
```
