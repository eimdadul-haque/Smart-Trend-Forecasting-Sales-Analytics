import { Component, OnInit } from '@angular/core';
import { ChartConfiguration, ChartData, ChartType } from 'chart.js';

@Component({
  selector: 'app-dashboard',
  standalone: false,
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent implements OnInit {
  // Quick stats data
  stats = [
    { title: 'Total Users', value: 1245, icon: 'bi-people', trend: 'up', change: 12 },
    { title: 'Revenue', value: '$34,546', icon: 'bi-currency-dollar', trend: 'up', change: 8 },
    { title: 'Products', value: 245, icon: 'bi-box-seam', trend: 'down', change: 3 },
    { title: 'Conversion', value: '3.6%', icon: 'bi-graph-up', trend: 'up', change: 1.2 }
  ];

  // Recent activity data
  recentActivities = [
    { user: 'John Doe', action: 'Created new product', time: '2 mins ago' },
    { user: 'Jane Smith', action: 'Updated settings', time: '10 mins ago' },
    { user: 'Robert Johnson', action: 'Completed order #1234', time: '25 mins ago' },
    { user: 'Emily Davis', action: 'Registered new account', time: '1 hour ago' }
  ];

  // Chart configurations
  public lineChartData: ChartConfiguration['data'] = {
    datasets: [
      {
        data: [65, 59, 80, 81, 56, 55, 40],
        label: 'Product Views',
        backgroundColor: 'rgba(13, 110, 253, 0.2)',
        borderColor: 'rgba(13, 110, 253, 1)',
        pointBackgroundColor: 'rgba(13, 110, 253, 1)',
        pointBorderColor: '#fff',
        fill: 'origin'
      },
      {
        data: [28, 48, 40, 19, 86, 27, 90],
        label: 'Purchases',
        backgroundColor: 'rgba(25, 135, 84, 0.2)',
        borderColor: 'rgba(25, 135, 84, 1)',
        pointBackgroundColor: 'rgba(25, 135, 84, 1)',
        pointBorderColor: '#fff',
        fill: 'origin'
      }
    ],
    labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July']
  };

  public lineChartOptions: ChartConfiguration['options'] = {
    responsive: true,
    maintainAspectRatio: false,
    scales: {
      y: {
        beginAtZero: true
      }
    }
  };

  public lineChartType: ChartType = 'line';

  public pieChartData: ChartData<'pie', number[], string | string[]> = {
    labels: ['Desktop', 'Mobile', 'Tablet'],
    datasets: [{
      data: [300, 500, 200],
      backgroundColor: ['#0d6efd', '#198754', '#fd7e14']
    }]
  };

  public pieChartOptions: ChartConfiguration['options'] = {
    responsive: true,
    maintainAspectRatio: false
  };

  public pieChartType: ChartType = 'pie';

  constructor() { }

  ngOnInit(): void {
  }
}