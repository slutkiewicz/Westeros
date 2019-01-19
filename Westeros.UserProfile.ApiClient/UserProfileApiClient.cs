﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Westeros.UserProfile.ApiClient.Contracts;
using Microsoft.Extensions.Configuration;

namespace Westeros.UserProfile.ApiClient
{
    public class UserProfileApiClient : IUserProfileApiClient
    {
        HttpClient _httpClient;

        public UserProfileApiClient(string baseAddress)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseAddress);
        }



        public async void AddUser(UserDto userToAdd)
        {
            await _httpClient.PostAsJsonAsync("api/Users", userToAdd);
        }
        public async void UpdatePerson(UserDto userToUpdate)
        {
            await _httpClient.PutAsJsonAsync("api/Users", userToUpdate);
        }
        public IEnumerable<UserDto> All()
        {
            return _httpClient
                .GetAsync("api/People")
                .Result
                .Content
                .ReadAsAsync<IEnumerable<UserDto>>()
                .Result;
        }
        public UserDto GetById(int id)
        {
            return _httpClient
                       .GetAsync($"api/People/{id}")
                       .Result
                       .Content
                       .ReadAsAsync<UserDto>()
                       .Result;
        }

        public async void DeleteUser(int id)
        {
            await _httpClient.DeleteAsync($"api/People/{id}");
        }

    }
}
