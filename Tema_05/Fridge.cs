using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema5_Zadacha
{
    class Fridge
    {
        private class Product
        {
            public string Name { get; set; }
            public Product next;

            public Product(string name)
            {
                this.Name = name;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }

        private Product head;
        private Product tail;
        private int count = 0;

        public int GetLength()
        {
            return count;
        }

        private bool isEmpty()
        {
            return head == null;
        }

        public void AddProduct(string ProductName)
        {
            Product temp = new Product(ProductName);

            if (isEmpty())
            {
                head = tail = temp;
                count++;
            }
            else
            {
                tail.next = temp;
                tail = temp;
                count++;
            }
        }

        private int IndexOf(string prod)
        {
            Product temp = head;
            int index = 0;

            while (temp != null)
            {
                if (temp.Name == prod)
                {
                    return index;
                }

                temp = temp.next;
                index++;
            }

            return -1;
        }

        public bool CheckProductIsInStock(string name)
        {
            return IndexOf(name) != -1;
        }

        private Product getPrevious(Product prod)
        {
            Product temp = head;
            while (temp.next != prod)
            {
                temp = temp.next;
            }
            return temp;
        }

        public string RemoveProductByIndex(int index)
        {
            if (index > count || isEmpty())
            {
                return null;
            }
            else
            {
                if (head == tail)
                {
                    string removed = head.Name;
                    head = tail = null;
                    count = 0;

                    return removed;
                }
                if (index == 0)
                {
                    string removed = head.Name;
                    Product second = head.next;
                    head.next = null;
                    head = second;

                    return removed;
                }
                else // Това може да даде проблем
                {
                    Product temp = head;

                    for (int i = 0; i < index; i++)
                    {
                        temp = temp.next;
                    }

                    string removed = temp.Name;
                    Product previous = getPrevious(temp), next = temp.next;
                    previous.next = next;
                    temp = null;

                    count--;

                    return removed;
                }
            }
        }

        public string RemoveProductByName(string name)
        {
            return RemoveProductByIndex(IndexOf(name));
        }

        public string[] CookMeal(int start, int end)
        {
            string[] cooked = new string[end - start + 1];
            Product temp = head;

            for (int i = 0; i < start; i++)
            {
                temp = temp.next;
            }

            int index = 0;
            for (int i = start; i <= end; i++)
            {
                if (temp != null)
                {
                    cooked[index] = temp.Name;
                    temp = temp.next;
                    index++;
                }
            }

            return cooked;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] products = new string[count];
            Product temp = head;
            int index = 0;

            while (temp != null)
            {
                products[index] = temp.ToString();
                temp = temp.next;
                index++;
            }

            return products;
        }
    }
}
