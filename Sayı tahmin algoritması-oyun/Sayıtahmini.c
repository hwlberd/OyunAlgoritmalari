
#include <stdio.h>
#include <time.h>
int main() {
TEKRAR:	//Tekrar oynamak isterse uygulama buraya gelicektir
srand(time(0));

int TahminSayisi, Tahmin, GizliSayi,i , DogruTahmin = 0;
int oyuncuSkor,bilgisayarSkor,devamEt;

TahminSayisi =rand()%3 + 7; // 7 ve 3 fazlas� 10 aras�nda (10 dahil de�il) rastgele hak �retiyor

GizliSayi = rand()%900 + 100; // 100 ile 100+900=1000 aras�nda 1000dahil de�il rastgele say� �retiyor

printf ( "Gizli Sayi = %d\n", GizliSayi);



printf ( "100 ile 999 arasinda tutulan sayiyi tahmin ediniz...\n%d Tahmininiz var\n\n",TahminSayisi );

for ( i = 1; i <= TahminSayisi; i++) { //tahmin say�s� kadar tahmin etme hakk� veriliyor ve program �al��maya bas�l�or
	
BASLA:
	
 printf ( "%d. tahminizi giriniz: ", i );
 
 scanf ("%d", &Tahmin);
 
 if(Tahmin<100 || Tahmin>999){ //girilen tahminin 100 ile 999 aras�nda olmas�n�n kontrol� burada ger�ekle�iyor
 	
 	printf ( "100 ile 999 arasinda bir sayi giriniz !\n");
 	
 	goto BASLA;
 }
 else{
 	
 	if ( Tahmin == GizliSayi ) { // say� bulunur ise oyuncuya puan ekliyor
 	
 DogruTahmin = 1;
 
 printf ( "%d. tahmininizde Bildiniz... \nTEBRIKLER...\n\n", i);
 
 oyuncuSkor=oyuncuSkor+1;
 
 break; 
 
 }
 else if (Tahmin < GizliSayi){ //tahmin k���k ise ipucu verilir
 	printf ("Tahminiz Kucuk...\n");
 }
 
 
 
 else{ 							//tahmin b�y�k ise ipucu verilir
  
 	
 	printf ( "Tahmininiz Buyuk...\n");
 }
 
 
}

 }
 
 if ( DogruTahmin == 0 ){ // say� bulunamaz ise gizlisay�y� g�sterip bilgisayara puan ekliyor
 	
	printf ( "\nTahmin Sayiniz Bitti... Gizli Sayi = %d idi\n\n", GizliSayi );
 	bilgisayarSkor=bilgisayarSkor+1;
 }
 
 printf("Bilgisayarin skoru =%d  Oyuncu skoru=%d\n" ,bilgisayarSkor,oyuncuSkor);
 
 printf("Tekrar oynamak ister misiniz ?\n  1-> evet  0-> hayir\n");
 
 scanf("%d",&devamEt);
 
 if(devamEt==0){
 	
 	goto SON; //uygulama bitirilecektir
 }
 else{
 	
 	goto TEKRAR; //tekrar k�sm�na gidip uygulama tekrar edicektir
 }
 

 SON:
 	printf("Bilgisayarin skoru =%d  Oyuncu skoru=%d\n" ,bilgisayarSkor,oyuncuSkor);
 return 0;
}

