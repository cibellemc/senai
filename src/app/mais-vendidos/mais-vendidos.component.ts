import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-mais-vendidos',
  templateUrl: './mais-vendidos.component.html',
  styleUrl: './mais-vendidos.component.css',
})
export class MaisVendidosComponent {
  @Input()
  valor: string = '';
}
