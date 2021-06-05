﻿using FairPlayTube.Common.Global;
using FairPlayTube.Models.CustomHttpResponse;
using FairPlayTube.Models.UserProfile;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static FairPlayTube.Common.Global.Constants;

namespace FairPlayTube.ClientServices
{
    public class UserProfileClientService
    {
        private HttpClientService HttpClientService { get; }

        public UserProfileClientService(HttpClientService httpClientService)
        {
            this.HttpClientService = httpClientService;
        }

        public async Task SaveMonetizationAsync(GlobalMonetizationModel globalMonetizationModel)
        {
            var authorizedHttpClient = this.HttpClientService.CreateAuthorizedClient();
            var response = await authorizedHttpClient.PostAsJsonAsync(ApiRoutes.UserProfileController.SaveMonetization, 
                globalMonetizationModel);
            if (!response.IsSuccessStatusCode)
            {
                ProblemHttpResponse problemHttpResponse = await response.Content.ReadFromJsonAsync<ProblemHttpResponse>();
                if (problemHttpResponse != null)
                    throw new Exception(problemHttpResponse.Detail);
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<GlobalMonetizationModel> GetMyMonetizationInfo()
        {
            var authorizedHttpClient = this.HttpClientService.CreateAuthorizedClient();
            return await authorizedHttpClient.GetFromJsonAsync<GlobalMonetizationModel>(
                Constants.ApiRoutes.UserProfileController.GetMyMonetizationInfo);
        }
    }
}
