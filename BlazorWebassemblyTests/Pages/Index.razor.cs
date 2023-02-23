using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorWebassemblyTests;
using BlazorWebassemblyTests.Shared;
using System.Text;

namespace BlazorWebassemblyTests.Pages
{
    public partial class Index
    {
        public MyInput Input { get; set; } = new();
        private void SaveSignature()
        {
            memoryService.Signature = Input.Signature;
        }

        private void OpenSignature()
        {
            navigationManager.NavigateTo(Input.SignatureAsBase64);
        }

        private void ReadSignature()
        {
            Input.Signature = memoryService.Signature;
            StateHasChanged();
        }
    }

    public class MyInput
    {
        public byte[] Signature { get; set; } = Array.Empty<byte>();
        public string SignatureAsBase64 => Encoding.UTF8.GetString(Signature);
    }
}