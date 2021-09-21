import java.util.Scanner;

public class Main 
{
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        try {
            System.out.println("Введите первое число: ");
            double num1 = in.nextDouble();

            System.out.println("Введите второе число: ");
            double num2 = in.nextDouble();

            if(num2 == 0){
                throw new Exception("Деление на 0 не предусмотрено");
            }

            double res = num1 / num2;
            System.out.print("Ответ: ");
            System.out.println(res);
        }
        catch(Exception error){
            System.out.println("Деление на 0 не предусмотрено");
        }
        finally{
            System.out.println("Конец программы");
        }
    }
}
