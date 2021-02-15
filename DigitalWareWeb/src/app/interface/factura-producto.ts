export interface FacturaProducto {
    Id: number
    FacturaId: number;
    ProductoId: number;
    Cantidad: number;
    ValorTotal: number;
    //complementarias
    ProductoNombre: string;
  }