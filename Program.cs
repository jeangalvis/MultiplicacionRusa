Console.Write("Ingrese Multiplicador: ");
int multiplicador = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese Multiplicando: ");
int multiplicando = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
int validador = 0;
while(validador !=1){
    if(multiplicador == 1){
        validador = 1;
    }
    if(multiplicador%2!=0){
        resultado = resultado + multiplicando;
    }
    multiplicador = multiplicador/2;
    multiplicando = multiplicando*2;
}
Console.WriteLine("Resultado: "+ resultado);