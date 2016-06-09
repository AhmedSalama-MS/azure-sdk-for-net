// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Divides text using language-specific rules.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.MicrosoftLanguageTokenizer")]
    public partial class MicrosoftLanguageTokenizer : Tokenizer
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftLanguageTokenizer class.
        /// </summary>
        public MicrosoftLanguageTokenizer() { }

        /// <summary>
        /// Initializes a new instance of the MicrosoftLanguageTokenizer class.
        /// </summary>
        public MicrosoftLanguageTokenizer(string name, int? maxTokenLength = default(int?), bool? isSearchTokenizer = default(bool?), MicrosoftTokenizerLanguage? language = default(MicrosoftTokenizerLanguage?))
            : base(name)
        {
            MaxTokenLength = maxTokenLength;
            IsSearchTokenizer = isSearchTokenizer;
            Language = language;
        }

        /// <summary>
        /// Gets or sets the maximum token length. Tokens longer than the
        /// maximum length are split. Maximum token length that can be used
        /// is 300 characters. Tokens longer than 300 characters are first
        /// split into tokens of length 300 and then each of those tokens is
        /// split based on the max token length set. Default is 255.
        /// </summary>
        [JsonProperty(PropertyName = "maxTokenLength")]
        public int? MaxTokenLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating how the tokenizer is used. Set to
        /// true if used as the search tokenizer, set to false if used as the
        /// indexing tokenizer. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "isSearchTokenizer")]
        public bool? IsSearchTokenizer { get; set; }

        /// <summary>
        /// Gets or sets the language to use. Possible values include:
        /// 'bangla', 'bulgarian', 'catalan', 'chinese_simplified',
        /// 'chinese_traditional', 'croatian', 'czech', 'danish', 'dutch',
        /// 'english', 'french', 'german', 'greek', 'gujarati', 'hindi',
        /// 'icelandic', 'indonesian', 'italian', 'japanese', 'kannada',
        /// 'korean', 'malay', 'malayalam', 'marathi', 'norwegian_bokmaal',
        /// 'polish', 'portuguese', 'portuguese_brazilian', 'punjabi',
        /// 'romanian', 'russian', 'serbian_cyrillic', 'serbian_latin',
        /// 'slovenian', 'spanish', 'swedish', 'tamil', 'telugu', 'thai',
        /// 'ukrainian', 'urdu', 'vietnamese'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public MicrosoftTokenizerLanguage? Language { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
