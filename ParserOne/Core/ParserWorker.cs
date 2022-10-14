using System;
using AngleSharp.Html.Parser;

namespace ParserOne.Core
{
     class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings settings;
        HtmlLoader loader; 
        bool isActive;

        #region Props

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return settings;
            }
            set
            {
                settings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
            
        }

        public ParserWorker(IParser<T> parser, IParserSettings settings) : this(parser)
        {
            this.settings = settings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = settings.StartPoint; i <= settings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();
                var d =  domParser.ParseDocument(source);

                var result  = parser.Parse(d);
                
                OnNewData?.Invoke(this, result);

            }
            OnCompleted?.Invoke(this);
            isActive = false;

        }
        
    }
}