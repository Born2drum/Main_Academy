using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{

    enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    };

    class Money
    {
        public double Amount;
        public CurrencyTypes CurrencyType;
        public Money()
        {
        }
        public Money(double Amount, CurrencyTypes CurrencyType)
        {
            this.CurrencyType = CurrencyType;
            this.Amount = Amount;
        }

        public static Money operator ++(Money first)
        {
            first.Amount += 1;
            return first;
        }
        
        public static Money operator --(Money first)
        {
            first.Amount -= 1;
            return first;
        }

        public static Money operator *(Money first, int x)
        {
            first.Amount = first.Amount* x;
            return first;
        }

        public static bool operator true(Money first)
        {
            if (first.CurrencyType == CurrencyTypes.UAH) return true;
            else return false;
        }

        public static bool operator false(Money first)
        {
            if (first.CurrencyType == CurrencyTypes.UAH) return true;
            else return false;
        }

        public static Money operator +(Money first, double a)
        {
            first.Amount = first.Amount + a;
            return first;
        }

        public static bool operator >(Money first, Money second)
        {
            if (first.CurrencyType == second.CurrencyType)
                if (first.Amount > second.Amount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            else
            {
                if (first.CurrencyType == CurrencyTypes.UAH)
                {
                    if (second.CurrencyType == CurrencyTypes.USD)
                    {
                        second.Amount *= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        second.Amount *= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (first.CurrencyType == CurrencyTypes.USD)
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;

                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;

                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public static bool operator <(Money first, Money second)
        {
            if (first.CurrencyType == second.CurrencyType)
                if (first.Amount > second.Amount)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            else
            {
                if (first.CurrencyType == CurrencyTypes.UAH)
                {
                    if (second.CurrencyType == CurrencyTypes.USD)
                    {
                        second.Amount *= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        second.Amount *= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else if (first.CurrencyType == CurrencyTypes.USD)
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;

                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;

                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        if (first.Amount > second.Amount)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
        }

        public static Money operator +(Money first, Money second)
        {
            if (first.CurrencyType == second.CurrencyType)
                return new Money{Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType};
            else
            {
                if(first.CurrencyType== CurrencyTypes.UAH)
                {
                    if(second.CurrencyType == CurrencyTypes.USD)
                    {
                        second.Amount *= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }else
                    {
                        second.Amount *= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }
                }
                else if(first.CurrencyType == CurrencyTypes.USD)
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;

                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }
                    else
                    {
                        first.Amount /= 26;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 30;
                        second.CurrencyType = CurrencyTypes.UAH;
                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }
                }
                else
                {
                    if (second.CurrencyType == CurrencyTypes.UAH)
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;

                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }
                    else
                    {
                        first.Amount /= 30;
                        first.CurrencyType = CurrencyTypes.UAH;
                        second.Amount /= 26;
                        second.CurrencyType = CurrencyTypes.UAH;
                        return new Money { Amount = first.Amount + second.Amount, CurrencyType = first.CurrencyType };
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money f = new Money(32, CurrencyTypes.UAH);
            Money s = new Money(10, CurrencyTypes.EU);
            Money t = new Money();
            t = f + s;
            f = f + 10.0;
            Console.WriteLine(t.Amount);
            s--;
            f++;
            bool m = f > s;
            if (f)
            {
                Console.WriteLine("F is UAH");
            }
            Console.WriteLine(t.Amount);
            t*=3;
            Console.WriteLine(t.Amount);
            Console.WriteLine(f > s);
            Console.ReadKey();


        }
    }
}
