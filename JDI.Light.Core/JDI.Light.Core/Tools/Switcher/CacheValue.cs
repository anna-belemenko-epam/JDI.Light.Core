﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JDI.Light.Core.Tools.Switcher
{
    public class CacheValue<T>
    {
        private static ThreadLocal<long> globalCache = new ThreadLocal<long>();

        private static long GetGlobalCache()
        {
            if (globalCache.Value == 0)
            {
                globalCache.Value = 0L;
            }
            return globalCache.Value;
        }

        public static void Reset()
        {
            globalCache.Value = DateTime.Now.Millisecond;
        }

        private long _elementCache = 0;
        private T _value;
        private bool _isFinal = false;
        private Func<T> _getRule = null;

        public CacheValue()
        {

        }

        public CacheValue(Func<T> getRule) { _getRule = getRule; }

        public bool IsUseCache() => _elementCache > -1;

        public void Clear()
        {
            if (!_isFinal)
                _value = default(T);
        }

        public void SetRule(Func<T> getRule)
        {
            _getRule = getRule;
        }

        public bool HasValue()
        {
            return _isFinal || IsUseCache() && _value != null && _elementCache == GetGlobalCache();
        }

        public T Get(Func<T> defaultResult)
        {
            if (_isFinal)
                return _value;
            if (!IsUseCache())
                return defaultResult.Invoke();
            if (_elementCache >= GetGlobalCache() && _value != null) return _value;
            _value = _getRule.Invoke();
            _elementCache = GetGlobalCache();
            return _value;
        }

        public T Get()
        {
            return Get(_getRule);
        }

        public T GetForce()
        {
            Reset();
            return Get();
        }

        public void UseCache(bool value) => _elementCache = value ? 0 : -1;

        public T SetForce(T value)
        {
            if (_isFinal)
                return value;
            _elementCache = GetGlobalCache();
            _value = value;
            return value;
        }

        public T SetFinal(T value)
        {
            _value = value;
            _isFinal = true;
            return value;
        }

        public T Set(T value)
        {
            return _isFinal || !IsUseCache()
                ? value
                : SetForce(value);
        }
    }
}
