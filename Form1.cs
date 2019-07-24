using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {


        DataTable memory = new DataTable();
        static DataTable processes = new DataTable();

        List<int> holes_size = new List<int>();
        List<int> start_address = new List<int>();
        List<string> h_state = new List<string>();
        List<int> processes_size = new List<int>();
        List<int> p_start_address = new List<int>();
        List<string> allocated_process = new List<string>();
        List<int> new_size = new List<int>();
        List<string> processes_name = new List<string>();
        List<string> p_state = new List<string>();
        int num_processes = 0 ,nhole=0,p_size=0;
        string p_deallocate = " " ,process_allocate=" ";
        static bool First = false , best=false;


        static void First_Fit_process(List<int> Holes_size,List<string> h_state,List<int> h_start_add,int process_size, string p, List<string> p_state, List<int> start_p, List<string> allocated_pro,List<int> new_size)
        {
            int resize = 0, restart = 0;
            int done = 0;
            bool yes = true;
            for (int j = 0; j < Holes_size.Count && yes; j++)
            {

                if (process_size <= Holes_size[j] && h_state[j]=="hole")
                {
                    start_p.Add(h_start_add[j]);
                    allocated_pro.Add(p);
                    p_state.Add("running");
                    new_size.Add(process_size);

                    resize = Holes_size[j] - process_size;
                    restart = h_start_add[j] + process_size;
                    if (resize != 0)
                    {
                        Holes_size.RemoveAt(j);
                        Holes_size.Insert(j, resize);
                        h_start_add.RemoveAt(j);
                        h_start_add.Insert(j, restart);
                        h_state.RemoveAt(j);
                        h_state.Insert(j, "fregmentation");

                    }
                    else
                    {
                        h_start_add.RemoveAt(j);
                        Holes_size.RemoveAt(j);
                        h_state.RemoveAt(j);
                    }

                    done = 1;
                    yes = false;
                }
            }
            if (done == 0)
            {
                start_p.Add(000000);
                allocated_pro.Add(p);
                p_state.Add("waiting");
                new_size.Add(process_size);

            }
        }

        static void First_Fit(int nprocess,List<int> Holes_size,List<string>h_state, List<int> h_start_add, List<int> process_size, List<string> p, List<string> p_state, List<int> start_p, List<string> allocated_pro, int nhole,List<int> new_size)
        {
            int resize = 0, restart = 0;
            for (int i = 0; i < p.Count; i++)
            {
                int done = 0;
                bool yes = true;
                for (int j = 0; j < nhole && yes; j++)
                {

                    if (process_size[i] <= Holes_size[j]&& h_state[j]=="hole")
                    {
                        start_p.Add(h_start_add[j]);
                        allocated_pro.Add(p[i]);
                        p_state.Add("running");
                        new_size.Add(process_size[i]);

                        resize = Holes_size[j] - process_size[i];
                        restart = h_start_add[j] + process_size[i];
                        if (resize != 0)
                        {
                            Holes_size.RemoveAt(j);
                            Holes_size.Insert(j, resize);
                            h_start_add.RemoveAt(j);
                            h_start_add.Insert(j, restart);
                            h_state.RemoveAt(j);
                            h_state.Insert(j,"fregmentation");

                        }
                        else
                        {
                          h_start_add.RemoveAt(j);
                          Holes_size.RemoveAt(j);
                          h_state.RemoveAt(j);
                          nhole--;
                        }

                        done = 1;
                        yes=false;
                    }
                }
                if (done == 0)
                {
                    start_p.Add(000000);
                    allocated_pro.Add(p[i]);
                    p_state.Add("waiting");
                    new_size.Add(process_size[i]);

                }
            }
            
        }
        static void First_Fit_deallocate(List<int> Holes_size, List<string> h_state, List<int> h_start_add,List<string> p_state, List<int> start_p, List<string> allocated_pro,List<int> new_size)
        {
            int resize = 0, restart = 0;
            for (int i = 0; i < allocated_pro.Count; i++)
            {
                bool yes = true;
                for (int j = 0; j < Holes_size.Count && yes; j++)
                {

                    if (new_size[i] <= Holes_size[j] && h_state[j] == "hole" && p_state[i]=="waiting")
                    {
                        start_p.RemoveAt(i);
                        start_p.Insert(i,h_start_add[j]);
                        p_state.RemoveAt(i);
                        p_state.Insert(i,"running");

                        resize = Holes_size[j] - new_size[i];
                        restart = h_start_add[j] + new_size[i];
                        if (resize != 0)
                        {
                            Holes_size.RemoveAt(j);
                            Holes_size.Insert(j, resize);
                            h_start_add.RemoveAt(j);
                            h_start_add.Insert(j, restart);
                            h_state.RemoveAt(j);
                            h_state.Insert(j, "fregmentation");

                        }
                        else
                        {
                            h_start_add.RemoveAt(j);
                            Holes_size.RemoveAt(j);
                            h_state.RemoveAt(j);
                            
                        }
                        yes = false;
                        for (int k = 0; k < processes.Rows.Count; k++)
                        {
                            if (allocated_pro[i] == Convert.ToString(processes.Rows[k][0]))
                            {
                                processes.Rows.RemoveAt(k);
                                processes.Rows.Add(allocated_pro[i], p_state[i], start_p[i], new_size[i]);
                            }
                        }
                    }
                }
            }
        }

        static void deallocated(string p_deallocate, List<int> Holes_size, List<string> h_state, List<int> h_start_add, List<int> new_size, List<string> p_state, List<int> start_p, List<string> allocated_pro)
        {
            int index = allocated_pro.IndexOf(p_deallocate);  // index of running process is the same index of it's start address
            int resize = 0;
            int post_address = start_p[index];
            int pre_address = start_p[index] + new_size[index];
            int done = 0;

            for (int j = 0; j < Holes_size.Count; j++)
            {
                if ((post_address == (Holes_size[j] + h_start_add[j]))&&(h_state[j]=="fregmentation"))
                {
                    resize = Holes_size[j] + new_size[index];
                    Holes_size.RemoveAt(j);
                    Holes_size.Insert(j, resize);
                    h_state.RemoveAt(j);
                    h_state.Insert(j,"hole");
                    done = 1;
                    break;
                }
                else if ((pre_address == h_start_add[j] )&& (h_state[j] == "fregmentation"))
                {
                    resize = Holes_size[j] + new_size[index];
                    Holes_size.RemoveAt(j);
                    Holes_size.Insert(j, resize);
                    h_start_add.RemoveAt(j);
                    h_start_add.Insert(j, post_address);
                    h_state.RemoveAt(j);
                    h_state.Insert(j, "hole");
                    done = 1;
                    break;
                }
            }
            if (done == 0 && p_state[index]=="running")
            {
              Holes_size.Add(new_size[index]);
              h_start_add.Add(post_address);
              h_state.Add("hole");
            }

            start_p.RemoveAt(index);
            allocated_pro.RemoveAt(index);
            p_state.RemoveAt(index);
            new_size.RemoveAt(index);
        }
        static void sort_holes_size(List<int> Holes_size, List<int> h_start_add,List<string> h_state)
        {
            for (int i = 0; i < Holes_size.Count - 1; i++)
            {
                for (int j = 0; j < Holes_size.Count - i - 1; j++)
                {
                    if (Holes_size[j] > Holes_size[j+1])
                    {
                        int temp = Holes_size[j];
                        Holes_size[j] = Holes_size[j + 1];
                        Holes_size[j + 1] = temp;

                        int addres_temp = h_start_add[j];
                        h_start_add[j] = h_start_add[j + 1];
                        h_start_add[j + 1] = addres_temp;

                        string s_temp = h_state[j];
                        h_state[j] = h_state[j + 1];
                        h_state[j + 1] = s_temp;
                    }

                }
            }
        }

        static void sort_holes_address(List<int> Holes_size, List<int> h_start_add,List <string> h_state)
        {
            for (int i = 0; i < Holes_size.Count - 1; i++ )
            {
                for (int j = 0; j < Holes_size.Count -i-1; j++)
                {
                    if (h_start_add[j] > h_start_add[j + 1])
                    {
                        int temp = Holes_size[j];
                        Holes_size[j] = Holes_size[j + 1];
                        Holes_size[j + 1] = temp;

                        int addres_temp = h_start_add[j] ;
                        h_start_add[j] = h_start_add[j + 1] ;
                        h_start_add[j + 1] = addres_temp ;

                        string s_temp = h_state[j];
                        h_state[j] = h_state[j + 1];
                        h_state[j + 1] = s_temp;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            processes.Columns.Add("process name",typeof(string));
            processes.Columns.Add("process state");
            processes.Columns.Add("process address");
            processes.Columns.Add("process size");
            process_grid_view.DataSource = processes;

            memory.Columns.Add("hole size");
            memory.Columns.Add("hole address");
            memory.Columns.Add("hole state");
            memory_grid_view.DataSource =memory;
        }

        private void submit_memory_Click(object sender, EventArgs e)
        {
            int done = 0;

           if(holes_size.Count<nhole)
            {
                holes_size.Add(Convert.ToInt32(Hole_size.Text));
                start_address.Add(Convert.ToInt32(start_add.Text));
                h_state.Add("hole");
                memory.Rows.Add(Hole_size.Text, start_add.Text ,h_state[h_state.Count-1]);
                Hole_size.Text = "";
                start_add.Text = "";
                done = 1;
            }
           if (done==0)
           {
               MessageBox.Show("You exceeded number of holes");
               Hole_size.Text = "";
               start_add.Text = "";
               Hole_no.Text = "";
               sort_holes_address(holes_size, start_address,h_state);
           }


        }
        
        private void process_no_TextChanged(object sender, EventArgs e)
        {
            num_processes = Convert.ToInt32(process_no.Text);
        }

        private void Add_process_Click(object sender, EventArgs e)
        {
            int done = 0;
            if(processes_name.Count<num_processes)
            {
                processes_name.Add(process_name.Text);
                processes_size.Add(Convert.ToInt32(process_size.Text));
                process_name.Text = "";
                process_size.Text="";
                done = 1;
            }
            if (done == 0)
            {
                MessageBox.Show("You exceeded number of processes");
                process_name.Text = "";
                process_size.Text = "";
            }
        }

        private void Hole_no_TextChanged(object sender, EventArgs e)
        {
            nhole = Convert.ToInt32(Hole_no.Text);
        }

        private void Firt_Fit_Click(object sender, EventArgs e)
        {
            First = true;
            best = false;
            First_Fit(num_processes,holes_size,h_state, start_address, processes_size, processes_name, p_state, p_start_address, allocated_process, nhole, new_size);
            if (holes_size.Count == 0)
            {
                memory.Rows.Clear();
            }
            else
            {
                for (int i = 0; i < memory.Columns.Count; i++)
                {
                    for (int j = 0; j < holes_size.Count; j++)
                    {
                        if (i == 0)
                        { memory.Rows[j][i] = holes_size[j]; }
                        if (i == 1)
                        { memory.Rows[j][i] = start_address[j]; }
                        if (i == 2)
                        { memory.Rows[j][i] = h_state[j]; }
                    }
                }
            }
            for (int i = 0; i < allocated_process.Count; i++)
            {
              processes.Rows.Add(allocated_process[i], p_state[i], p_start_address[i], new_size[i]);
            }
        }

        private void Bet_Fit_Click(object sender, EventArgs e)
        {
            best = true;
            First = false;
            sort_holes_size(holes_size, start_address,h_state);
            First_Fit(num_processes, holes_size,h_state, start_address, processes_size, processes_name, p_state, p_start_address, allocated_process, nhole, new_size);
        
            if (holes_size.Count == 0)
            {
                memory.Rows.Clear();
            }
            else
            {
                for (int i = 0; i < memory.Columns.Count; i++)
                {
                    for (int j = 0; j < holes_size.Count; j++)
                    {
                        if (i == 0)
                        { memory.Rows[j][i] = holes_size[j]; }
                        if (i == 1)
                        { memory.Rows[j][i] = start_address[j]; }
                        if (i == 2)
                        { memory.Rows[j][i] = h_state[j]; }
                    }
                }
            }
            for (int i = 0; i < allocated_process.Count; i++)
            {
                processes.Rows.Add(allocated_process[i], p_state[i], p_start_address[i], new_size[i]);
            }
        }

        private void p_allocate_TextChanged(object sender, EventArgs e)
        {
            p_deallocate = p_allocate.Text;
        }

        private void Deallocate_Click(object sender, EventArgs e)
        {
            deallocated(p_deallocate, holes_size,h_state, start_address, new_size, p_state, p_start_address, allocated_process);
            First_Fit_deallocate(holes_size,h_state,start_address,p_state,p_start_address,allocated_process,new_size);
        
            if (memory.Rows.Count == 0)
            {
                for (int j = 0; j < holes_size.Count; j++)
                {
                    memory.Rows.Add(holes_size[j], start_address[j],h_state[j]);
                }
            }
            else
            {
                for (int i = 0; i < memory.Columns.Count; i++)
                {
                    for (int j = 0; j < holes_size.Count; j++)
                    {
                        if (i == 0)
                        {memory.Rows[j][i] = holes_size[j];}
                        if (i == 1)
                        { memory.Rows[j][i] = start_address[j]; }
                        if (i == 2)
                        { memory.Rows[j][i] = h_state[j]; }
                    }
                }
            }
            for (int j = 0; j < processes.Rows.Count; j++)
            {
                if (Convert.ToString(processes.Rows[j][0]) == p_deallocate)
                {
                    processes.Rows.RemoveAt(j);
                }
            }
        }

        private void allocate_Click(object sender, EventArgs e)
        {
            process_allocate = P.Text;
            p_size = Convert.ToInt32(size.Text);

            if (First)
            {
                P.Text="";
                size.Text="";
                First_Fit_process(holes_size,h_state, start_address, p_size, process_allocate, p_state, p_start_address, allocated_process, new_size);

                if (holes_size.Count == 0)
                {
                    memory.Rows.Clear();
                }
                else
                {
                    for (int i = 0; i < memory.Columns.Count; i++)
                    {
                        for (int j = 0; j < holes_size.Count; j++)
                        {
                            if (i == 0)
                            { memory.Rows[j][i] = holes_size[j]; }
                            if (i == 1)
                            { memory.Rows[j][i] = start_address[j]; }
                            if (i == 2)
                            { memory.Rows[j][i] = h_state[j]; }
                        }
                    }
                }

                int indexx=0 ;
                indexx= allocated_process.Count - 1;             
                processes.Rows.Add(allocated_process[indexx], p_state[indexx], p_start_address[indexx], new_size[indexx]);
                
            }
            if (best)
            {
                P.Text = "";
                size.Text = "";
                sort_holes_size(holes_size, start_address,h_state);
                First_Fit_process(holes_size,h_state, start_address, p_size, process_allocate, p_state, p_start_address, allocated_process, new_size);

                if (holes_size.Count == 0)
                {
                    memory.Rows.Clear();
                }
                else
                {
                    for (int i = 0; i < memory.Columns.Count; i++)
                    {
                        for (int j = 0; j < holes_size.Count; j++)
                        {
                            if (i == 0)
                            { memory.Rows[j][i] = holes_size[j]; }
                            if (i == 1)
                            { memory.Rows[j][i] = start_address[j]; }
                            if (i == 2)
                            { memory.Rows[j][i] = h_state[j]; }
                        }
                    }
                }
                int indexx = 0;
                indexx = allocated_process.Count - 1;
                processes.Rows.Add(allocated_process[indexx], p_state[indexx], p_start_address[indexx], new_size[indexx]);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
