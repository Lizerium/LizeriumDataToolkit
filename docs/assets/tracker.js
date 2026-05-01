;(function () {
	fetch('https://license.dvurechensky.pro/api/v1/log', {
		method: 'POST',
		headers: {
			'Content-Type': 'application/json',
		},
		body: JSON.stringify({
			site: location.hostname,
			path: location.pathname,
			event_type: 'pageview',
			referrer: document.referrer || '',
			utm_source: new URLSearchParams(location.search).get('utm_source') || '',
			utm_medium: new URLSearchParams(location.search).get('utm_medium') || '',
			utm_campaign:
				new URLSearchParams(location.search).get('utm_campaign') || '',
			title: document.title || '',
			language: navigator.language || '',
			viewport: window.innerWidth + 'x' + window.innerHeight,
		}),
	}).catch(function () {})
})()
