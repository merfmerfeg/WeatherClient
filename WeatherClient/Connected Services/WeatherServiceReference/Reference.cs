﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherClient.WeatherServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WeatherItem", Namespace="http://schemas.datacontract.org/2004/07/WeatherService")]
    [System.SerializableAttribute()]
    public partial class WeatherItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WeatherClient.WeatherServiceReference.Cloudiness CloudinessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HumidityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WeatherClient.WeatherServiceReference.Precipitation PrecipitationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PressureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TemperatureFeelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WindField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeatherClient.WeatherServiceReference.Cloudiness Cloudiness {
            get {
                return this.CloudinessField;
            }
            set {
                if ((this.CloudinessField.Equals(value) != true)) {
                    this.CloudinessField = value;
                    this.RaisePropertyChanged("Cloudiness");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Humidity {
            get {
                return this.HumidityField;
            }
            set {
                if ((this.HumidityField.Equals(value) != true)) {
                    this.HumidityField = value;
                    this.RaisePropertyChanged("Humidity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WeatherClient.WeatherServiceReference.Precipitation Precipitation {
            get {
                return this.PrecipitationField;
            }
            set {
                if ((this.PrecipitationField.Equals(value) != true)) {
                    this.PrecipitationField = value;
                    this.RaisePropertyChanged("Precipitation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pressure {
            get {
                return this.PressureField;
            }
            set {
                if ((this.PressureField.Equals(value) != true)) {
                    this.PressureField = value;
                    this.RaisePropertyChanged("Pressure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((this.TemperatureField.Equals(value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TemperatureFeel {
            get {
                return this.TemperatureFeelField;
            }
            set {
                if ((this.TemperatureFeelField.Equals(value) != true)) {
                    this.TemperatureFeelField = value;
                    this.RaisePropertyChanged("TemperatureFeel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Wind {
            get {
                return this.WindField;
            }
            set {
                if ((this.WindField.Equals(value) != true)) {
                    this.WindField = value;
                    this.RaisePropertyChanged("Wind");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cloudiness", Namespace="http://schemas.datacontract.org/2004/07/WeatherService")]
    public enum Cloudiness : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        туман = -1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ясно = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        малооблачно = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        облачно = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        пасмурно = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Precipitation", Namespace="http://schemas.datacontract.org/2004/07/WeatherService")]
    public enum Precipitation : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        смешанные = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        дождь = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ливень = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        снег = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        снегопад = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        гроза = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        нет_данных = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        без_осадков = 10,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WeatherServiceReference.IWeatherService")]
    public interface IWeatherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetWeatherDataLast", ReplyAction="http://tempuri.org/IWeatherService/GetWeatherDataLastResponse")]
        WeatherClient.WeatherServiceReference.WeatherItem GetWeatherDataLast(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetWeatherDataLast", ReplyAction="http://tempuri.org/IWeatherService/GetWeatherDataLastResponse")]
        System.Threading.Tasks.Task<WeatherClient.WeatherServiceReference.WeatherItem> GetWeatherDataLastAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetWeatherDataByDate", ReplyAction="http://tempuri.org/IWeatherService/GetWeatherDataByDateResponse")]
        WeatherClient.WeatherServiceReference.WeatherItem[] GetWeatherDataByDate(string city, System.DateTime dateStart, System.DateTime dateEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetWeatherDataByDate", ReplyAction="http://tempuri.org/IWeatherService/GetWeatherDataByDateResponse")]
        System.Threading.Tasks.Task<WeatherClient.WeatherServiceReference.WeatherItem[]> GetWeatherDataByDateAsync(string city, System.DateTime dateStart, System.DateTime dateEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetMainCityList", ReplyAction="http://tempuri.org/IWeatherService/GetMainCityListResponse")]
        string[] GetMainCityList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherService/GetMainCityList", ReplyAction="http://tempuri.org/IWeatherService/GetMainCityListResponse")]
        System.Threading.Tasks.Task<string[]> GetMainCityListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServiceChannel : WeatherClient.WeatherServiceReference.IWeatherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServiceClient : System.ServiceModel.ClientBase<WeatherClient.WeatherServiceReference.IWeatherService>, WeatherClient.WeatherServiceReference.IWeatherService {
        
        public WeatherServiceClient() {
        }
        
        public WeatherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WeatherClient.WeatherServiceReference.WeatherItem GetWeatherDataLast(string city) {
            return base.Channel.GetWeatherDataLast(city);
        }
        
        public System.Threading.Tasks.Task<WeatherClient.WeatherServiceReference.WeatherItem> GetWeatherDataLastAsync(string city) {
            return base.Channel.GetWeatherDataLastAsync(city);
        }
        
        public WeatherClient.WeatherServiceReference.WeatherItem[] GetWeatherDataByDate(string city, System.DateTime dateStart, System.DateTime dateEnd) {
            return base.Channel.GetWeatherDataByDate(city, dateStart, dateEnd);
        }
        
        public System.Threading.Tasks.Task<WeatherClient.WeatherServiceReference.WeatherItem[]> GetWeatherDataByDateAsync(string city, System.DateTime dateStart, System.DateTime dateEnd) {
            return base.Channel.GetWeatherDataByDateAsync(city, dateStart, dateEnd);
        }
        
        public string[] GetMainCityList() {
            return base.Channel.GetMainCityList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetMainCityListAsync() {
            return base.Channel.GetMainCityListAsync();
        }
    }
}