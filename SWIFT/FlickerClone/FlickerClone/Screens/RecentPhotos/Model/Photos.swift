//
//  Photos.swift
//  FlickerClone
//
//  Created by Yunus Emre Kaya on 16.07.2022.
//

import Foundation

struct Photos: Codable {
    let page, pages, perpage, total: Int?
    let photo: [Photo]?
}
