﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Xunit;

namespace Microsoft.WindowsAzure.Commands.ScenarioTest
{
    public partial class ServiceManagementTests
    {
        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestGetAzureVM()
        {
            this.RunPowerShellTest("Test-GetAzureVM");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestGetAzureLocation()
        {
            this.RunPowerShellTest("Test-GetAzureLocation");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunServiceManagementCloudExceptionTests()
        {
            this.RunPowerShellTest("Run-ServiceManagementCloudExceptionTests");
        }
        
        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunStartAndStopMultipleVirtualMachinesTest()
        {
            this.RunPowerShellTest("Run-StartAndStopMultipleVirtualMachinesTest");
        }
    }
}
