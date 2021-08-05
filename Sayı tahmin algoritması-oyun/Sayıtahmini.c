
#include <stdio.h>
#include <time.h>
int main() {
TEKRAR:	//Tekrar oynamak isterse uygulama buraya gelicektir
srand(time(0));

int TahminSayisi, Tahmin, GizliSayi,i , DogruTahmin = 0;
int oyuncuSkor,bilgisayarSkor,devamEt;

TahminSayisi =rand()%3 + 7; // 7 ve 3 fazlasý 10 arasýnda (10 dahil deðil) rastgele hak üretiyor

GizliSayi = rand()%900 + 100; // 100 ile 100+900=1000 arasýnda 1000dahil deðil rastgele sayý üretiyor

printf ( "Gizli Sayi = %d\n", GizliSayi);



printf ( "100 ile 999 arasinda tutulan sayiyi tahmin ediniz...\n%d Tahmininiz var\n\n",TahminSayisi );

for ( i = 1; i <= TahminSayisi; i++) { //tahmin sayýsý kadar tahmin etme hakký veriliyor ve program çalýþmaya basþlýor
	
BASLA:
	
 printf ( "%d. tahminizi giriniz: ", i );
 
 scanf ("%d", &Tahmin);
 
 if(Tahmin<100 || Tahmin>999){ //girilen tahminin 100 ile 999 arasýnda olmasýnýn kontrolü burada gerçekleþiyor
 	
 	printf ( "100 ile 999 arasinda bir sayi giriniz !\n");
 	
 	goto BASLA;
 }
 else{
 	
 	if ( Tahmin == GizliSayi ) { // sayý bulunur ise oyuncuya puan ekliyor
 	
 DogruTahmin = 1;
 
 printf ( "%d. tahmininizde Bildiniz... \nTEBRIKLER...\n\n", i);
 
 oyuncuSkor=oyuncuSkor+1;
 
 break; 
 
 }
 else if (Tahmin < GizliSayi){ //tahmin küçük ise ipucu verilir
 	printf ("Tahminiz Kucuk...\n");
 }
 
 
 
 else{ 							//tahmin büyük ise ipucu verilir
  
 	
 	printf ( "Tahmininiz Buyuk...\n");
 }
 
 
}

 }
 
 if ( DogruTahmin == 0 ){ // sayý bulunamaz ise gizlisayýyý gösterip bilgisayara puan ekliyor
 	
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
 	
 	goto TEKRAR; //tekrar kýsmýna gidip uygulama tekrar edicektir
 }
 

 SON:
 	printf("Bilgisayarin skoru =%d  Oyuncu skoru=%d\n" ,bilgisayarSkor,oyuncuSkor);
 return 0;
}

