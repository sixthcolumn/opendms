package com.sixthc.util;

import java.io.IOException;
import java.io.StringReader;
import java.util.Iterator;

import javax.xml.XMLConstants;
import javax.xml.namespace.NamespaceContext;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.xpath.XPath;
import javax.xml.xpath.XPathConstants;
import javax.xml.xpath.XPathExpressionException;
import javax.xml.xpath.XPathFactory;

import org.apache.log4j.Logger;
import org.w3c.dom.Document;
import org.w3c.dom.NodeList;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;

public class XmlStringParser {
	private Document payloadDoc;
	private UniversalNamespaceResolver unr;
	private static org.apache.log4j.Logger log = Logger
			.getLogger(XmlStringParser.class);

	public XmlStringParser(String xmlString)
			throws ParserConfigurationException, SAXException, IOException {
		DocumentBuilderFactory builderFactory = DocumentBuilderFactory
				.newInstance();
		builderFactory.setNamespaceAware(true);
		DocumentBuilder builder = builderFactory.newDocumentBuilder();

		InputSource inputSource = new InputSource(new StringReader(xmlString));
		payloadDoc = builder.parse(inputSource);
		unr = new UniversalNamespaceResolver(payloadDoc);
	}

	public String getTagValue(String tag, String namespace) throws ParserConfigurationException,
			IOException, SAXException {
		String prefix = unr
				.getPrefix(namespace);

		XPath xpath = XPathFactory.newInstance().newXPath();
		xpath.setNamespaceContext(unr);

		try {
			String xpathString = "//" + prefix + ":" + tag + "/text()";
			System.out.println("xpath : " + xpathString);
			NodeList nodes = (NodeList) xpath.evaluate(xpathString, payloadDoc,
					XPathConstants.NODESET);
			if (nodes.getLength() > 0) {
				org.w3c.dom.Node n = nodes.item(0);
				return n.getNodeValue();
			}
		} catch (XPathExpressionException e) {
			// TODO Auto-generated catch block
			log.error(e);
		}
		return "";
	}

	public String getHeaderValueWC(String tag) throws ParserConfigurationException,
			IOException, SAXException {

		XPath xpath = XPathFactory.newInstance().newXPath();
		xpath.setNamespaceContext(unr);

		try {
			String xpathString = "//*[local-name()='Header']/*[local-name()='" + tag + "']/text()";
			System.out.println("xpath : " + xpathString);
			NodeList nodes = (NodeList) xpath.evaluate(xpathString, payloadDoc,
					XPathConstants.NODESET);
			if (nodes.getLength() > 0) {
				org.w3c.dom.Node n = nodes.item(0);
				return n.getNodeValue();
			}
		} catch (XPathExpressionException e) {
			// TODO Auto-generated catch block
			log.error(e);
		}
		return "";
	}

	private static class UniversalNamespaceResolver implements NamespaceContext {
		// the delegate
		private Document sourceDocument;

		/**
		 * This constructor stores the source document to search the namespaces
		 * in
		 * it.
		 * 
		 * @param document
		 *            source document
		 */
		public UniversalNamespaceResolver(Document document) {
			sourceDocument = document;
		}

		/**
		 * The lookup for the namespace uris is delegated to the stored
		 * document.
		 * 
		 * @param prefix
		 *            to search for
		 * @return uri
		 */
		public String getNamespaceURI(String prefix) {
			if (prefix.equals(XMLConstants.DEFAULT_NS_PREFIX)) {
				return sourceDocument.lookupNamespaceURI(null);
			} else {
				return sourceDocument.lookupNamespaceURI(prefix);
			}
		}

		/**
		 * This method is not needed in this context, but can be implemented in
		 * a
		 * similar way.
		 */
		public String getPrefix(String namespaceURI) {
			return sourceDocument.lookupPrefix(namespaceURI);
		}

		public Iterator getPrefixes(String namespaceURI) {
			// not implemented yet
			return null;
		}

	}
}
