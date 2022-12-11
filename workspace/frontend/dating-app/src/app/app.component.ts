import { HttpClient } from '@angular/common/http'
import { Component, OnInit } from '@angular/core'
import { map, Observable, tap } from 'rxjs'

import { User } from './models/user.model'
import { Response } from './responses/response'

import { faCoffee } from '@fortawesome/free-solid-svg-icons'

@Component({
  selector: 'da-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Dating Client'
  faCoffee = faCoffee

  users$!: Observable<User[]>

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.users$ = this.http.get<Response<User[]>>('/api/users').pipe(
      tap({ error: (e) => console.error(e) }),
      map((response) => response.data),
    )
  }
}
