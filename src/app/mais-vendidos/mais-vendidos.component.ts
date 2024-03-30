import { Component, Input, OnInit } from "@angular/core";
import { Produto } from "../models/Produto.models";
import { ProdutoService } from "../produto.service";

@Component({
  selector: "app-mais-vendidos",
  templateUrl: "./mais-vendidos.component.html",
  styleUrl: "./mais-vendidos.component.css",
})
export class MaisVendidosComponent implements OnInit {
  @Input()
  valor: string = "";

  public produtos: Produto[] = [];
  constructor(private _produtoService: ProdutoService) {}
  ngOnInit(): void {
    this.listarProdutos();
  }
  listarProdutos(): void {
    this._produtoService.getProdutos().subscribe((retornaProduto) => {
      this.produtos = retornaProduto.map((item) => {
        return new Produto(
          item.id,
          item.produto,
          item.descricao,
          item.foto,
          item.preco
        );
      });
    });
  }
}
