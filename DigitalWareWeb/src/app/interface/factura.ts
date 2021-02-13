export interface Factura {
    Id: number
    ClienteId: number;
    ValorTotal: number;
    Fecha: Date;
    //Propiedades Complementarias
    ClienteNombre: string;
  }