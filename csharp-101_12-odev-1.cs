using System;
using System.Text;

namespace patika_dev {

	class csharp_101_12_odev_1 {

		static void Main () {

			/*
			Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin ( n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
				Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
			
			Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
				Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
			
			Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
				Sonrasında kullanıcıdan n adet kelime girmesi isteyin.Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
			
			Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
				Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
			*/

			var tInStr = "";

			// 1111111
			Console.WriteLine( $"\r\n\r\n{nameof( p1_Cevap )};" );
			Console.Write( "Pozitif 1 Sayı ( n ) :  yazıp / enterleyin " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "4"; }
			var p1N = int.Parse( tInStr );

			Console.Write( $"Pozitif {p1N} adet sayıyı ( 16 14 13 20 )  yazıp / enterleyin " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "16 14 13 20"; }
			var p1Arr = tInStr.Split( ' ' ).ToList().Select( arrTemp => Convert.ToInt32( arrTemp ) ).ToList().Take( p1N ).ToList(); ;

			p1_Cevap( p1N, p1Arr );


			// 2222222222222
			Console.WriteLine( $"\r\n\r\n{nameof( p2_Cevap )};" );
			Console.Write( "Pozitif 2 Tam Sayıyı ( n m ) ( örn: 6 3 ) {boşluk} ile yazıp / enterleyin " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "6 3"; }
			var p2Arr = tInStr.TrimEnd().Split( ' ' ).ToList().Select( arrTemp => Convert.ToInt32( arrTemp ) ).ToList().Take( 2 ); ;

			Console.Write( $"Pozitif {p2Arr.First()} adet sayıyı ( 16 14 13 20 5 3 ... )  yazıp / enterleyin " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "16 14 13 20 5 3"; }
			var p2Arr2 = tInStr.Split( ' ' ).ToList().Select( arrTemp => Convert.ToInt32( arrTemp ) ).ToList().Take( p2Arr.First() ).ToList(); ;
			p2_Cevap( p2Arr.Last(), p2Arr2 );

			// 3333333333333
			Console.WriteLine( $"\r\n\r\n{nameof( p3_Cevap )};" );
			Console.Write( "Pozitif 1 Sayı ( n ) yazıp / enterleyin : " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "6"; }
			var p3N = int.Parse( tInStr );
			Console.Write( $"Pozitif {p3N} adet Kelime Girin ( Selam Hi Ehlen GotenTough WellComen )  yazıp / enterleyin " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "Selam Hi Ehlen GotenTough WellComen"; }
			var p3Arr = tInStr.Split( ' ' ).ToList().Take( p3N ).ToList(); ;
			p3_Cevap( p3Arr );

			// 4444444444444
			Console.WriteLine( $"\r\n\r\n{nameof( p4_Cevap )};" );
			Console.Write( "1 Cümle ( Ali çembere gir ) yazıp / enterleyin : " );
			tInStr = Console.ReadLine().TrimEnd(); if ( tInStr == "" ) { tInStr = "Ali çembere gir"; }
			var p4N = tInStr;
			p4_Cevap( p4N );

			}



		/*
		Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin ( n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
			Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
		*/
		private static void p1_Cevap ( int p1N, List<int> p1Arr ) {

			foreach ( int ÇiftMi in p1Arr ) {
				if ( ( ÇiftMi & 1 ) != 1 ) { Console.WriteLine( $"{ÇiftMi}" ); }
				}
			}

		/*
		Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
			Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
		*/
		private static void p2_Cevap ( int böl, List<int> p2Arr2 ) {
			foreach ( var p2 in p2Arr2 )
				if ( p2 % böl == 0 ) { Console.Write( $"{p2} ,  " ); }
			}

		/*
		Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
			Sonrasında kullanıcıdan n adet kelime girmesi isteyin.Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
		*/
		private static void p3_Cevap ( List<string> p3Arr ) {
			p3Arr.Reverse();
			foreach ( var item in p3Arr ) {
				Console.Write( $"{item} , " );
				}
			}

		/*
		Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
			Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
		*/
		private static void p4_Cevap ( string p4N ) {
			var Kelime = p4N.Split( ' ' ).Count();
			Console.Write( $"{Kelime} Adet Kelime. {p4N.Replace( " ", "" ).Count()} Harf " );
			}
		}
	}