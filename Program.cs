namespace ThapHN
{
    public class Program
    {
        public void Move(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine($"----{A},{B},{C}-----");
                Console.WriteLine($"{n} == 1 {A} ==>{C}");


            }
            else
            {   // A = 'A', C = 'B', B = 'C'
                Console.WriteLine($"+++++{A},{B},{C}+++++");
                Move(n - 1, A, C, B);
                Console.WriteLine($"{n} {A} ==> {C}"); // (1)
                // B A C
                Move(n - 1, B, A, C);
                

            }
        }
        /* 
    #       Move(3, A, B, C)
                A = 'A0', B = 'B0', C = 'C0'
                lenh: +++++{A}{B}{C}++++
                => print: +++++A0,B0,C0+++++
    ##          lenh:(2, A, C, B)
                Move(2, A0, C0, B0)
                    A0 = 'A1', C0 = 'B1', B0 = 'C1'
                    lenh: +++++{A0}{B0}{C0}++++
                     => print: +++++A1,C1,B1+++++
                    
    ###             lenh(1, A0, C0, B0)
                    Move(1, A1, B1, C1)
                        A1 = 'A2', B1 = 'B2', C1 = 'C2'

                        lenh: -----{A1}{B1}{C1}-----
                        => print: -----A2,B2,C2-----
                        lenh: {n} == 1 {A1} ==>{C1}
        **              => print: 1 == 1 A2 ==> C2

                    lenh: {n} {A0} ==> {C0}
        **          => print: 2 A1 ==> B1

    ###             lenh: Move(1, B0, A0, C0)
                    Move(1, C1, A1, B1)
                    B1 = 'A4', C1 = 'B4', A1 = 'C4'

                    lenh: -----{A1}{B1}{C1}-----
                    => print: -----C4,A4,B4-----
                    lenh: {n} == 1 {A1} ==>{C1}
        **          => print: 1 == 1 C4 ==> B4

    #       lenh: {n} {A} ==> {C}
        **  => print: 3 A0 ==> C0
                
    ##          lenh: Move(2, B, A, C)
                Move(2, B0, A0, C0)
                    B0 = 'A5', A0 = 'B5', C0 = 'C5'
                    lenh: +++++{A0}{B0}{C0}++++
                    => print: +++++B5,A5,C5+++++

                    lenh: Move(1, A0, C0, B0)
                        Move(1, B5, C5, A5)
                        B5 = A6, C5 = B6, A5 = C6

                        lenh: -----{A5}{B5}{C5}-----
                        => print: -----C6,A6,B6-----
                        lenh: {n} == 1 {A5} ==>{C5}
        **              => print: 1 == 1 B6 ==> A6

                    lenh: {n} {A0} ==> {C0}
        **          => print: 2 B5 ==> C5

                    lenh: Move(1, B0, A0, C0)
                    Move(1, A5, B5, C5)
                        A5 = A7, B5 = B7, C5 = C7

                        lenh: -----{A5}{B5}{C5}-----
                        => print: -----A7,B7,C7-----
                        lenh: {n} == 1 {A5} ==>{C5}
        **              => print: 1 == 1 A7 ==> C7

        */




        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Move(3, 'A', 'B', 'C'); 

        }
    }
}


