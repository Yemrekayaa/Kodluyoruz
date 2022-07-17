//
//  NetworkManager.swift
//  FlickerClone
//
//  Created by Yunus Emre Kaya on 16.07.2022.
//

import Foundation

class NetworkManager{
    
    static let shared = NetworkManager()
    
    public func fetchImage(with url: String?, competion: @escaping (Data) -> Void){
        if let urlString = url, let url = URL(string: urlString) {
            let request = URLRequest(url: url)
            URLSession.shared.dataTask(with: request) { data, response, error in
                if let error = error {
                    print(error)
                    return
                }
                if let data = data {
                    DispatchQueue.main.async {
                        competion(data)
                    }
                    
                }
            }.resume()
        }
    }
}
