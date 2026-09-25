import {Component, inject, OnInit, signal} from '@angular/core';
import {RouterOutlet} from '@angular/router';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  private http = inject(HttpClient);
  protected readonly title = signal('client');
  protected members = signal<any>('members');

  ngOnInit(): void {
    this.http.get('http://localhost:5001/').subscribe({
      next: response => this.members.set(response),
      error: error => console.log(error),
      complete: () => console.log('complete Data Fetching...')
    })
  }


}
