import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Book } from '../model/Book';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})
export class ProductItemComponent {

  @Input()
  livro!: Book
  // @Output() imagemSelecionada = new EventEmitter<string>()

  // selecionarImagem(imagem:string){
  //   this.imagemSelecionada.emit(imagem)
  // }

  constructor(){}

  // getImagemURL(){
  //   return `/assets/images/ +${this.livro.imagem} +'.jpg`
  // }


}
