//
//      Copyright (C) 2012-2014 DataStax Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
//

using System;
using System.Linq;

namespace Cassandra.Data.Linq
{
    public interface ITable : IQueryProvider
    {
        void Create();
        Type GetEntityType();
        /// <summary>
        /// Gets the table name in Cassandra
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gets the name of the keyspace used. If null, it uses the active session keyspace.
        /// </summary>
        string KeyspaceName { get; }
        ISession GetSession();
        TableType GetTableType();
    }
}