import { UserPanelModule } from './../../shared/components/user-panel/user-panel.component';
import { element } from 'protractor';
import { Component } from '@angular/core';
import { Factura } from 'src/app/interface/factura';
import { HttpService } from 'src/app/shared/services/http.service';

@Component({
  templateUrl: 'facturacion.component.html',
  styleUrls: ['./facturacion.component.scss']
})
export class FacturacionComponent {
  facturas: Factura[];
  factura={} as Factura;
  msg: string;
  isLoading: boolean;
  popupVisible: boolean;
  constructor(private service: HttpService) {
    this.popupVisible = false;
    this.abrirFactura = this.abrirFactura.bind(this);
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
  crearFactura(){
    this.factura ={} as Factura;
    this.popupVisible = true;
  }
  crearFacturaAfterClose(){
    this.obtenerFacturas();
    this.popupVisible = false;
  }

  
  abrirFactura(e){    
    this.factura = e.row.data as Factura;
    this.popupVisible = true;
    e.event.preventDefault();     
  }

}
