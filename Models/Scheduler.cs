namespace Yandex.Cargo.Models {
    public class Scheduler : BackgroundService {
        private readonly IServiceProvider _serviceProvider;

        public Scheduler(IServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while (!stoppingToken.IsCancellationRequested) {
                using (var scope = _serviceProvider.CreateScope()) {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

                    var orders = dbContext.Orders
                    .Where(e => e.DateOfBirth < DateTime.Now.AddMinutes(-30))
                    .ToList();

                    foreach (var order in orders) {
                        order.State = "on the way";
                    }

                    dbContext.SaveChanges();

                    await Task.Delay(TimeSpan.FromMinutes(20), stoppingToken);
                }
            }
        }
    }
}
