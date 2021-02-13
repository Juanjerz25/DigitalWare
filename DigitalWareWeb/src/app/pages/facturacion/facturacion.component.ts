import { Component } from '@angular/core';
import { Factura } from 'src/app/interface/factura';
import { HttpService } from 'src/app/shared/services/http.service';

@Component({
  templateUrl: 'facturacion.component.html',
  styleUrls: ['./facturacion.component.scss']
})
export class FacturacionComponent {

  facturas: Factura[];
  msg: string;
  isLoading: boolean;
  constructor(private service: HttpService) {
    this.obtenerFacturas();
  }

  obtenerFacturas() {
    const model = {
      controlador: 'Factura',
      accion: 'ObtenerFacturas',
      parametros: {}
    } as any;

    this.service.post(model).subscribe(
      data => {
        this.facturas = data.Factura as Factura[];  // ok
      },
      error => (this.msg = (error as any)), // error
      () => (this.isLoading = false)        // onCompleted
    );

  }

}
