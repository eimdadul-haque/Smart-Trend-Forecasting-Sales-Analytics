import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-landing',
  standalone: false,
  templateUrl: './landing.component.html',
  styleUrl: './landing.component.scss'
})
export class LandingComponent {
  features = [
    {
      icon: 'bi-graph-up',
      title: 'Advanced Analytics',
      description: 'Get detailed insights into your product performance'
    },
    {
      icon: 'bi-lightning',
      title: 'Real-time Predictions',
      description: 'Instant results with our machine learning models'
    },
    {
      icon: 'bi-shield-lock',
      title: 'Secure Platform',
      description: 'Your data is always protected'
    }
  ];

  testimonials = [
    {
      quote: "This product increased our conversion rate by 35%!",
      author: "Sarah Johnson, Product Manager",
      company: "TechCorp"
    },
    {
      quote: "The most accurate predictions we've ever used.",
      author: "Michael Chen",
      company: "StartUp Inc"
    }
  ];

  constructor(
    private router: Router) {}

  navigateTo(route: string) {
    this.router.navigateByUrl('auth/login');
  }
}
