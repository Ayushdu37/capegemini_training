// // Declaration
// int[] numbers;

// // Initialization with size
// int[] num = new int[5];

// // Initialization with values
// // int[] nums = {1, 2, 3, 4, 5};

// // foreach loop
// // foreach(int x in nums)
// // {
// //     Console.WriteLine(x);
// // }

// // -------------------------- //

// // 2D array declaration
// int[,] matrix = new int[2,3];

// // 2D array declaration with initialization

// int[,] mat =
// {
//     {1,2},
//     {3,4}
// };

// // foreach(int x in mat)
// // {
// //     if(x == 4)
// //     {
// //         Console.WriteLine(x);
// //     }
// // }

// for(int i=0;i<mat.GetLength(0); i++)
// {
//     for(int j = 0; j < mat.GetLength(1); j++)
//     {
//         Console.Write(mat[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// // -------------------------- //

// // Jagged array declaration

// int[][] jagged = new int[2][];

// // Initialization
// jagged[0] = new int[] {1,2};
// jagged[1] = new int[] {3,4,5};

// // Accessing Elements
// Console.WriteLine(jagged[1][2]);

// for(int i=0; i<jagged.Length; i++)
// {
//     for(int j=0; j < jagged[i].Length; j++)
//     {
//         Console.Write(jagged[i][j] + " ");
//     }
//     Console.WriteLine();
// }

// // --------------------------- //

// // Array.Clear
// int[] data = {10,20,30};
// Array.Clear(data, 1, data.Length - 1);
// foreach(int x in data)
// {
//     Console.WriteLine(x);
// }

// // --------------------------- //

// // Array.Copy
// int[] src = {1,2,3};
// int[] dest = new int[3];

// // Array.Copy(src , dest, 1);
// // Array.Copy(src , dest, 2);
// Array.Copy(src , dest, 3);

// foreach(int x in dest)
// {
//     Console.WriteLine(x);
// }

// // --------------------------- //

// // Array.Resize

// int[] nums = {1,2};
// Array.Resize(ref nums, 4);
// foreach(int x in nums)
// {
//     Console.Write(x + " ");
// }

// // --------------------------- //

// // Array.Exists()

// int[] ex = {1,2,3,4,5};

// bool found = Array.Exists(ex, x => x > 2); // always use bool otherwise it wont work
// Console.WriteLine(found);