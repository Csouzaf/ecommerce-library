import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from './model/Book';
import { Observable, tap } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class ServicesService {

  private urlAPI = "https://localhost:7299/api/livraria";

  httpOptions={
    Headers: new HttpHeaders({ 'content-type':'application/json'})
  }

  constructor(private http: HttpClient){}

  // getBook(){
  //   return this.http.get(this.urlAPI)
  // }
  // getBook(){
  //   return this.http.get<Book[]>(this.urlAPI)
  //     .pipe(
  //       tap(livros => console.log(livros))
  //     )
  // }

  getBook(): Observable<Book[]> {
    return this.http.get<Book[]>(this.urlAPI);
  }
}
