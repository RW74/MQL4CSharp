﻿/*
Copyright 2016 Jason Separovic

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;

namespace MQL4CSharp.Base.Common
{
    public abstract class BaseRiskProfile
    {
        private BaseStrategy strategy;

        public BaseRiskProfile(BaseStrategy strategy)
        {
            this.strategy = strategy;
        }

        public abstract double getLotSize(String symbol, double stopDistance);
    }
}
