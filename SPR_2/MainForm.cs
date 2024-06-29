using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace SPR_2;

public partial class MainForm : Form
{
    private Dec<int> dec;
    private Random random;
    private int[] arr1;
    private List<int[]> steps = new List<int[]>();
    private int currentIndex = -1;
    private Graph graph = new Graph(4);

    public MainForm()
    {
        InitializeComponent();
        dec = new Dec<int>();
        random = new Random();

        graph.Add(0, 1);
        graph.Add(0, 3);
        graph.Add(1, 2);
        graph.Add(2, 0);
        graph.Add(2, 3);
    }

    private void UpdateTextBox()
    {
        textBoxTypeData.Clear();

        Dec<int> tmp = new Dec<int>();

        while (!dec.IsEmpty())
        {
            int value = dec.PopBack();
            tmp.PushBack(value);
        }
        while (!tmp.IsEmpty())
        {
            int value = tmp.PopBack();
            textBoxTypeData.Text += value.ToString() + " ";
            dec.PushBack(value);
        }
    }

    private void buttonAddRandom_Click(object sender, EventArgs e)
    {
        int number = random.Next(-10, 10);
        dec.PushFront(number);
        textBoxTypeData.Text = dec.Peek().ToString() + " ";
    }

    private void buttonPop_Click(object sender, EventArgs e)
    {
        try
        {
            textBoxTypeData.Text = dec.Peek().ToString() + " ";
            dec.PopFront();
            //UpdateTextBox();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonAddRandomTail_Click(object sender, EventArgs e)
    {
        int number = random.Next(-10, 10);
        dec.PushBack(number);
        textBoxTypeData.Text = dec.PeekTail().ToString() + " ";
    }

    private void buttonPopTail_Click(object sender, EventArgs e)
    {
        try
        {
            textBoxTypeData.Text = dec.PeekTail().ToString() + " ";
            dec.PopBack();
            //UpdateTextBox();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void buttonPrint_Click(object sender, EventArgs e)
    {
        UpdateTextBox();
    }
    //*********************************************//
    private int[] Shell(int[] arr)
    {
        int j;
        for (int d = arr.Length / 2; d > 0; d /= 2)
        {
            for (int i = d; i < arr.Length; i++)
            {
                j = i;
                while ((j >= d) && (arr[j - d] > arr[j]))
                {
                    Swap(j, j - d, arr);
                    j -= d;
                    steps.Add(arr.ToArray());
                }
            }
        }
        return arr;
    }

    static void Swap(int i, int j, int[] arr)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private void buttonSort_Click(object sender, EventArgs e)
    {
        string[] massive = textBoxAlghoritmSort.Text.Split(" ");
        arr1 = new int[massive.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(textBoxAlghoritmSort.Text.Split(" ")[i]);
        }
        textBoxAlghoritmSort.Text = string.Empty;
        steps.Clear();
        currentIndex = -1;
        steps.Add(arr1.ToArray());
        Shell(arr1);

        for (int i = 0; i < arr1.Length; i++)
        {
            textBoxAlghoritmSort.Text += Convert.ToString(arr1[i]) + " ";
        }

        textBoxSortTask.Text += "алгоритм сортировки, являющийся усовершенствованным вариантом сортировки вставками. Идея метода Шелла состоит в сравнении элементов, стоящих не только рядом, но и на определённом расстоянии друг от друга";
    }


    private void ShowStep()
    {
        if (currentIndex >= 0 && currentIndex < steps.Count)
        {
            textBoxAlghoritmSort.Text = string.Join(" ", steps[currentIndex]);
        }
        else
        {
            textBoxAlghoritmSort.Text = string.Join(" ", arr1);
        }
    }

    private void buttonStepForward_Click(object sender, EventArgs e)
    {
        if (currentIndex < steps.Count - 1)
        {
            currentIndex++;
            ShowStep();
        }
    }

    private void buttonStepBack_Click(object sender, EventArgs e)
    {
        if (currentIndex > -1)
        {
            currentIndex--;
            ShowStep();
        }
    }


    //**********************************************************************//
    private void buttonMatrix_Click(object sender, EventArgs e)
    {
        textBoxAlghoritm.Text += "0, 1" + "\r\n" + "0, 3" + "\r\n" + "1, 2" + "\r\n" + "2, 0" + "\r\n" + "2, 3";


        listBoxExampleOfWork.Items.Clear();
        List<int> result = graph.BFS(1);
        foreach (var item in result)
        {
            listBoxExampleOfWork.Items.Add(item);
        }
    }
}



