import { Component, Input } from '@angular/core';

export interface Slide {
  imgSrc: string;
  imgAlt: String;
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
showNext(i: number) {
  if(this.selectedIndex < this.images?.length - 1){
    this.selectedIndex = i + 1;
  }
}
showPrev(i: number) {
  if(this.selectedIndex > 0){
    this.selectedIndex = i - 1;
  }
}
  @Input() images: Slide[] = [
    {
      imgSrc: 'assets/images/ss_a05.jpg',
      imgAlt: 'Samsung a05'
    },
    {
      imgSrc: 'assets/images/ss_a53.jpg',
      imgAlt: 'Samsung a53'
    },
    {
      imgSrc: 'assets/images/ss_asr.jpg',
      imgAlt: 'Samsung asr'
    },
    {
      imgSrc: 'assets/images/ss_glxWatch.jpg',
      imgAlt: 'Samsung glxWatch'
    },
    {
      imgSrc: 'assets/images/ss_glss.jpg',
      imgAlt: 'Samsung aglss'
    },
    {
      imgSrc: 'assets/images/ss_b1.jpg',
      imgAlt: 'Samsung b1'
    },
    {
      imgSrc: 'assets/images/ss_glxWatch1.jpg',
      imgAlt: 'Samsung glxWatch1'
    },
    {
      imgSrc: 'assets/images/ss_note.jpg',
      imgAlt: 'Samsung note'
    },
    {
      imgSrc: 'assets/images/ss_z.jpg',
      imgAlt: 'Samsung z'
    },
    {
      imgSrc: 'assets/images/ss_glxWatch2.jpg',
      imgAlt: 'Samsung glxWatch2'
    },
  ];

  selectedIndex = 0;
}
