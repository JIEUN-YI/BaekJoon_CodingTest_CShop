namespace BaekJoon_codingTest
{
    internal class _250406_Study
    {
        /// <summary>
        /// 제목 : 1008 - A/B
        /// URL : https://www.acmicpc.net/problem/1008
        /// 문제 : 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.
        /// </summary>
        /// 메모리 : 5512 KB
        /// 속도 : 48 ms
        private void Divide()
        {
            string answer = Console.ReadLine();
            string[] answerArr = answer.Split(" ");
            int.TryParse(answerArr[0], out int num1);
            int.TryParse(answerArr[1], out int num2);
            Console.WriteLine((double)num1 / num2);
        }

        /// <summary>
        /// 제목 : 1330 - 두 수 비교하기
        /// URL : https://www.acmicpc.net/problem/1330
        /// 문제 : 두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.
        /// </summary>
        /// 메모리 : 5492 KB
        /// 속도 : 48 ms
        private void Compare()
        {
            string answer = Console.ReadLine();
            string[] answerArr = answer.Split(" ");
            int.TryParse(answerArr[0], out int num1);
            int.TryParse(answerArr[1], out int num2);
            if (num1 < num2)
            {
                Console.WriteLine("<");
            }
            else if (num1 > num2)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("==");
            }
        }

        /// <summary>
        /// 제목 : 2438 - 별찍기
        /// URL : https://www.acmicpc.net/problem/2438
        /// 문제 : 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
        /// 메모리 : 6576 KB
        /// 속도 : 216 ms
        private void ShowStar()
        {
            int.TryParse(Console.ReadLine(), out int line);
            for (int i = 1; i <= line; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 제목 : 2557 - Hello World
        /// URL : https://www.acmicpc.net/problem/2557
        /// 문제 : Hello World!를 출력하시오.
        /// </summary>
        /// 메모리 : 5328 KB
        /// 속도 :  44 ms
        private void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        /// <summary>
        /// 제목 : 2739 - 구구단
        /// URL : https://www.acmicpc.net/problem/2739
        /// 문제 : N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.
        /// </summary>
        /// 메모리 : 5760 KB
        /// 속도 : 52 ms
        private void Multiplication()
        {
            int.TryParse(Console.ReadLine(), out int num);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
        /// <summary>
        /// 제목 : 10869 - 사칙연산
        /// URL : https://www.acmicpc.net/problem/10869
        /// 문제 : 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
        /// </summary>
        /// 메모리 : 5504 KB
        /// 속도 :  48 ms
        private void Operation()
        {
            string[] answerArr = Console.ReadLine().Split(" ");
            int.TryParse(answerArr[0], out int num1);
            int.TryParse(answerArr[1], out int num2);
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
        }
        /// <summary>
        /// 제목 : 10950 - A + B -3
        /// URL : https://www.acmicpc.net/problem/10950
        /// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        ///        첫째 줄에 테스트 케이스의 개수 T가 주어진다.
        ///        각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B< 10)
        /// </summary>
        /// 메모리 : 5516 KB
        /// 속도 :  56 ms
        private void AddNum3()
        {
            int.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                string[] answerArr = Console.ReadLine().Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);
                Console.WriteLine(num1 + num2);
            }
        }
        /// <summary>
        /// 제목 : 10951 - A + B - 4
        /// URL : https://www.acmicpc.net/problem/10951
        /// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        /// </summary>
        /// 메모리 : 5520 KB
        /// 속도 :  56 ms
        /// 총 6번 도전 => EOF(End of File)를 제대로 설정하지 못하여 발생 : 백준은 프로그래머스와 다르게 문제에 따라 설정이 필수적이므로 주의할 것
        private void AddNum4()
        {
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == null)
                {
                    break;
                }

                string[] answerArr = answer.Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);

                Console.WriteLine(num1 + num2);
            }
        }
        /// <summary>
        /// 제목 : 10952 - A + B - 5
        /// URL : https://www.acmicpc.net/problem/10952
        /// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
        ///        입력은 여러 개의 테스트 케이스로 이루어져 있다. 
        ///        각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B< 10)  입력의 마지막에는 0 두 개가 들어온다.
        /// </summary>
        /// 메모리 : 5516 KB
        /// 속도 :  56 ms
        private void AddNum5()
        {
            while (true)
            {
                string[] answerArr = Console.ReadLine().Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);
                if(num1 == 0 && num2 == 0)
                {
                    break;
                }
                Console.WriteLine(num1 + num2);
            }
        }
        /// <summary>
        /// 제목 : 11654 - 아스키 코드
        /// URL : https://www.acmicpc.net/problem/11654
        /// 문제 : 알파벳 소문자, 대문자, 숫자 0-9중 하나가 주어졌을 때, 주어진 글자의 아스키 코드값을 출력하는 프로그램을 작성하시오.
        ///        알파벳 소문자, 대문자, 숫자 0-9 중 하나가 첫째 줄에 주어진다.
        /// </summary>
        /// 메모리 : 5452 KB
        /// 속도 :  48 ms
        private void AsciiCode()
        {
            char.TryParse(Console.ReadLine(), out char c);
            Console.WriteLine((int)c);
        }
        /// <summary>
        /// 제목 : 25083 - 새싹
        /// URL : https://www.acmicpc.net/problem/25083
        /// 문제 : 예제와 같이 새싹을 출력하시오.
        /// </summary>
        /// 메모리 : 5328 KB
        /// 속도 :  44 ms
        private void Sprout()
        {
            Console.WriteLine("         ,r'\"7");
            Console.WriteLine("r`-_   ,'  ,/");
            Console.WriteLine(" \\. \". L_r'");
            Console.WriteLine("   `~\\/");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
        }
        /// <summary>
        /// 제목 : 27866 - 문자와 문자열
        /// URL : https://www.acmicpc.net/problem/27866
        /// 문제 : 단어 S와 정수 i가 주어졌을 때, S의 i번째 글자를 출력하는 프로그램을 작성하시오.
        /// </summary>
        /// 메모리 : 5476 KB
        /// 속도 :  52 ms
        private void FindIString()
        {
            string answer = Console.ReadLine();
            char[] chars = answer.ToCharArray();

            int.TryParse(Console.ReadLine(),out int num);
            Console.WriteLine(chars[num - 1]);
        }
        /// <summary>
        /// 제목 : 11720 - 숫자의 합
        /// URL : https://www.acmicpc.net/problem/11720
        /// 문제 : N개의 숫자가 공백 없이 쓰여있다. 이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.
        ///        첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다. 둘째 줄에 숫자 N개가 공백없이 주어진다.
        /// </summary>
        /// 메모리 : 5492 KB
        /// 속도 :  52 ms
        private void AddNumber()
        {
            int.TryParse(Console.ReadLine(), out int count);
            string numbers = Console.ReadLine();
            char[] numberArr = numbers.ToCharArray();
            if (numberArr.Length > count)
            {
                return;
            }
            int sum = 0;
            foreach(char c in numberArr)
            {
                int.TryParse(c.ToString(), out int num);
                sum += num;
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// 제목 : 2562 - 최댓값
        /// URL : https://www.acmicpc.net/problem/2562
        /// 문제 : 9개의 서로 다른 자연수가 주어질 때, 이들 중 최댓값을 찾고 그 최댓값이 몇 번째 수인지를 구하는 프로그램을 작성하시오. 
        ///        예를 들어, 서로 다른 9개의 자연수 3, 29, 38, 12, 57, 74, 40, 85, 61 이 주어지면, 
        ///        이들 중 최댓값은 85이고, 이 값은 8번째 수이다.
        /// 참고 : Dictionary<>의 정렬 방법 - https://developer-talk.tistory.com/293
        /// </summary>
        /// 메모리 : 5896 KB
        /// 속도 :  56 ms
        /// 람다식과 Dictionary의 OrderBy 를 이용한 정렬이 제대로 작동하지 않아 우회하여 풀이
        private void MaxNumIndex()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>(9);
            Dictionary<int, int> answer = new Dictionary<int, int>(9);
            for (int i = 0; i < 9; i++)
            {
                int.TryParse(Console.ReadLine(), out int num);
                numbers.Add(num, i);
            }
            // numbers.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
            List<int> list = numbers.Keys.ToList();
            list.Sort();
            list.Reverse();

            foreach (int num in list)
            {
                answer.Add(num, numbers[num]);
            }
            Console.WriteLine(answer.First().Key);
            Console.WriteLine(answer.First().Value + 1);
        }
        /// <summary>
        /// 제목 : 10818 - 최소, 최대
        /// URL : https://www.acmicpc.net/problem/10818
        /// 문제 : N개의 정수가 주어진다. 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오. 
        ///        첫째 줄에 정수의 개수 N (1 ≤ N ≤ 1,000,000)이 주어진다. 
        ///        둘째 줄에는 N개의 정수를 공백으로 구분해서 주어진다. 
        ///        모든 정수는 -1,000,000보다 크거나 같고, 1,000,000보다 작거나 같은 정수이다.
        /// </summary>
        /// 메모리 : 82872 KB
        /// 속도 : 364 ms
        /// 속도와 메모리가 아쉬운 편
        private void MaxMin()
        {
            int.TryParse(Console.ReadLine(), out int count);
            int[] numbers = new int[count];
            string[] answer = Console.ReadLine().Split(" ");
            if (answer.Length != count)
            {
                return;
            }
            for (int i = 0; i < count; i++)
            {
                int.TryParse(answer[i].ToString(), out int num);
                numbers[i] = num;
            }

            Array.Sort(numbers);
            Console.Write($"{numbers[0]} {numbers[count - 1]}");
        }
        /// <summary>
        /// 제목 : 2675 - 문자열 반복
        /// URL : https://www.acmicpc.net/problem/2675
        /// 문제 : 문자열 S를 입력받은 후에, 각 문자를 R번 반복해 새 문자열 P를 만든 후 출력하는 프로그램을 작성하시오. 
        ///        즉, 첫 번째 문자를 R번 반복하고, 두 번째 문자를 R번 반복하는 식으로 P를 만들면 된다. 
        ///        S에는 QR Code "alphanumeric" 문자만 들어있다.QR Code "alphanumeric" 문자는 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ\$%*+-./: 이다.
        /// </summary>
        /// 메모리 : 5536 KB
        /// 속도 :  44 ms
        private void RepeatChar()
        {
            int.TryParse(Console.ReadLine(), out int count);

            while (count > 0)
            {
                string[] input = Console.ReadLine().Split(" ");
                int.TryParse(input[0].ToString(), out int repeat);
                List<string> answer = new List<string>();
                foreach (char c in input[1])
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        answer.Add(c.ToString());
                    }
                }
                string result = string.Concat(answer.ToArray());
                Console.WriteLine(result);
                count--;
            }
        }

    }
}
