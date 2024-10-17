using Libreria;

Delfin d1 = new Delfin();
Delfin d2 = new Delfin();
Orca orca10 = new Orca();

Acuario acuario1 = new Acuario();

d1.nombre = "Primer nombre";
d2.nombre = "Segundo nombre";
orca10.nombre = "tercer nombre";
acuario1.Direccion = "avenida corongo";
acuario1.delfin = d1;
acuario1.delfin1 = d2;
acuario1.orca = orca10;
acuario1.ListaDeNombres();



