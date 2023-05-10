import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class ServicesService {

  private url = "https://localhost:7299/api/livraria";

  httpOptions={
    Headers: new HttpHeaders({ 'content-type':'application/json'})
  }

  constructor(private http: HttpClient){}

  getBook(){
    return this.http.get(this.url)
  }
}
