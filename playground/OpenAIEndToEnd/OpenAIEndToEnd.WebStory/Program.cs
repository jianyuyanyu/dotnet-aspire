// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;
using OpenAIEndToEnd.WebStory.Components;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.AddAzureOpenAIClient("openaiA").AddChatClient();

// Examples using multiple OpenAI resources and multiple models

//builder.AddKeyedAzureOpenAIClient("openaiB")
//    .AddKeyedChatClient("modelB1")
//    .AddKeyedChatClient("modelB2");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

ArgumentNullException.ThrowIfNull(app.Services.GetService<AzureOpenAIClient>());
ArgumentNullException.ThrowIfNull(app.Services.GetService<IChatClient>());

//ArgumentNullException.ThrowIfNull(app.Services.GetKeyedService<AzureOpenAIClient>("openaiB"));
//ArgumentNullException.ThrowIfNull(app.Services.GetKeyedService<IChatClient>("modelB1"));
//ArgumentNullException.ThrowIfNull(app.Services.GetKeyedService<IChatClient>("modelB2"));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
