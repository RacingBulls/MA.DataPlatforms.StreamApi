// <copyright file="PacketDtoMapper.cs" company="McLaren Applied Ltd.">
//
// Copyright 2024 McLaren Applied Ltd
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using MA.Streaming.Abstraction;
using MA.Streaming.Contracts;
using MA.Streaming.OpenData;

namespace MA.Streaming.Proto.Core.Mapper;

public class PacketDtoMapper : IMapper<Packet, PacketDto>
{
    public PacketDto Map(Packet source)
    {
        return new PacketDto(source.Type, source.SessionKey, source.IsEssential, source.Content.ToByteArray());
    }
}