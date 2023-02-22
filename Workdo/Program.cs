using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BlazorDateRangePicker;
using Plk.Blazor.DragDrop;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorDragDrop();
builder.Services.AddWMBSC();
builder.Services.AddDateRangePicker(config =>
{
  config.Culture = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
  config.DateFormat = "dd/MM/yyyy";
  config.TimePicker24Hour = true;
  config.TimePickerIncrement = 5;
  config.Opens = SideType.Right;
  config.ApplyLabel = "Xác nhận";
  config.CancelLabel = "Hủy";
  config.ButtonClasses = "button is-small";
  config.ApplyButtonClasses = "is-link";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();