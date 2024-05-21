using System;

public class Program
{
    public delegate void NavigatorTank(int id);
    public event NavigatorTank NavigateTank;

    public void OnNavigatorTank(int id)
    {
        NavigateTank?.Invoke(id);
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        // Đăng ký một phương thức xử lý sự kiện
        //program.NavigateTank += HandleEvolveTank;
        //program.NavigateTank += HandleUpgradeTank;
        Console.WriteLine();
        Console.WriteLine("Huy event HandleEvolveTank");
        program.NavigateTank += HandleEvolveTank;
        program.OnNavigatorTank(1);
        program.NavigateTank += HandleUpgradeTank;
        program.OnNavigatorTank(2);
        Console.WriteLine();
        Console.WriteLine("Huy event HandleUpgradeTank");
        program.NavigateTank += HandleMoveTank;
        program.OnNavigatorTank(3);
        program.NavigateTank += HandleKillTank;
        program.OnNavigatorTank(4);



        // Gọi phương thức OnNavigatorTank, sẽ kích hoạt sự kiện NavigateTank
        // program.OnNavigatorTank(4);
    }

    static void HandleEvolveTank(int id)
    {
        Console.WriteLine($"Da tien hoa tank co id la : {id}");
    }
    static void HandleUpgradeTank(int id)
    {
        Console.WriteLine($"Da nang cap tank co id la {id}");
    }
    static void HandleMoveTank(int id)
    {
        Console.WriteLine($"Da di chuyen tank co id la : {id}");
    }
    static void HandleKillTank(int id)
    {
        Console.WriteLine($"Da kill tank co id la {id}");
    }
}
