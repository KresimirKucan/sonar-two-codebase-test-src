import { Component, OnInit } from '@angular/core';
import {
  InfiniteScrollCustomEvent,
  LoadingController,
} from '@ionic/angular';
import { Car, MovieService } from 'src/app/services/movie.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.page.html',
  styleUrls: ['./movies.page.scss'],
})
export class MoviesPage implements OnInit {
  movies: any[];
  cars: Car[] = [];
  currentPage = 1;
  imageBaseUrl = environment.images;

  constructor(
    private movieService: MovieService,
    private loadingCtrl: LoadingController
  ) {
    this.movies = [];
  }

  ngOnInit() {
    this.loadMovies();

    this.movieService.getCars().subscribe((res) => {
      this.cars.push(res);
    });
    console.log(this.cars);
  }

  async loadMovies(event?: InfiniteScrollCustomEvent) {
    const loading = await this.loadingCtrl.create({
      message: 'Loading..',
      spinner: 'bubbles',
    });
    await loading.present();

    this.movieService.getTopRatedMovies(this.currentPage).subscribe((res) => {
      loading.dismiss();
      this.movies.push(...res.results);
      console.log(res);

      event?.target.complete();

      if (event) {
        event.target.disabled = res.total_pages === this.currentPage;
      }
    });
  }

  loadMore(event: InfiniteScrollCustomEvent) {
    this.currentPage++;
    this.loadMovies(event);
  }
}
