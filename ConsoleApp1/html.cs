using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			long sam = num;

			/*
		 * ��ʽת��
		 * int num = 55;
		long sam = num;
		sam = 99;
		sam = 88;
		sam = 99;
		*/


			/*��ʽת��
			 * 
			 * long num;
			int sam = 79;
			num = (int)sam;
			*/

			/*ǿ��ת��
			 * 
			 * long num;
			string sam= "78";

			int num =Convert.ToInt32(sam);*/

			/*string num = Console.ReadLine();
			int sam = Convert.ToInt32(num);*/
			//int num = int.Parse("89");
			//int a = 3;
			//int b = 2;
			//float c = (float)a / b;

			//int num = 3;
			//int sam = 4;
			//bool txt = !(num < sam);


			//�ַ���ƴ�Ӻ��ڲ�
			//string name = "Դվ";
			//string use = "��ӭ��";
			//Console.WriteLine(name + "," + use + "!");
			//Console.WriteLine($"{name}," + $"" + Environment.NewLine + "" + $"{use}!");
			//Console.WriteLine(@$"{name},



			//{use}!");
			/*			int num = Convert.ToInt32(Console.ReadLine());


						if (num < 100)
						{
							Console.WriteLine("�������С��һ�٣�");

						}
						else
						{
							Console.WriteLine("��������ִ���һ�٣�");
						}
		*//*				Console.WriteLine();*//*
			�ع����룬���Ӵ���Ŀɶ��ԣ�������Ͷȣ�
			int num =Convert.ToInt32( Console.ReadLine());
			string sam;
			if (num<=10)
			{
				sam = "�����������С��10";
			}
			else
			{
				sam = "����������ִ���10";
			}
			Console.WriteLine(sam);*/


			/*��Ԫ���ʽ�������
		   long sam = int.Parse(Console.ReadLine());
			string num = sam >= 10 ? "����" : "������";
			Console.WriteLine(num);*/
			//= Convert.ToString(Console.ReadLine());
			/*	string sam="";
				int num = Console.Read();// Convert.ToInt32(Console.ReadLine());
				if (num > 100 || num < 0) {
					sam = "��������ȷ�����֣�";
				}
				else if (num < 60)
				{
					sam = "������";
				}
				else if (num >= 60&&num<80)
				{
					sam = "����";
				}
				else if (num >= 80)
				{
					sam = "����";
				}
				Console.WriteLine(sam);*/

			Console.WriteLine("sam");
			Console.Read();
		}
	}
}
