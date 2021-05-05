/* 
 * Tripartie Web API
 *
 * This document describes all use cases offered by the Tripartie Web API.<br /><br /> The Tripartie Web API allows you to easily create Transaction templates.<br /> A Transaction template allows a User (the Buyer) to safely initiate a Transaction pre-configured by another User (the Seller).<br /> This allows you to add a Secured Payment button on your website pages.<br /><br /> To facilitate working with the Web API, we built libraries for common development environment:<br/> <ul class=\"bullet\">   <li><a target=\"_blank\" rel=\"noopener noreferrer\" href=\"https://github.com/tripartie/webapi-jsclient\">Javascript</a></li> </ul> <br/> You're reading the documentation for version 1.0 of the Web API.<br/> Go to version <select id=\"version-switcher\"></select> 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@tripartie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TripartieWebAPI.CSharpClient.Client;
using TripartieWebAPI.CSharpClient.Api;
using TripartieWebAPI.CSharpClient.Model;

namespace TripartieWebAPI.CSharpClient.Test
{
    /// <summary>
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UsersApi
            //Assert.IsInstanceOf(typeof(UsersApi), instance);
        }

        
        /// <summary>
        /// Test Unregister
        /// </summary>
        [Test]
        public void UnregisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalId = null;
            //int? tripartieId = null;
            //instance.Unregister(externalId, tripartieId);
            
        }
        
        /// <summary>
        /// Test Fetch
        /// </summary>
        [Test]
        public void FetchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string externalId = null;
            //int? tripartieId = null;
            //var response = instance.Fetch(externalId, tripartieId);
            //Assert.IsInstanceOf(typeof(ModelUser), response, "response is ModelUser");
        }
        
        /// <summary>
        /// Test Register
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestRegisterUser requestRegisterUser = null;
            //var response = instance.Register(requestRegisterUser);
            //Assert.IsInstanceOf(typeof(ModelUser), response, "response is ModelUser");
        }
        
    }

}
